using System.Formats.Asn1;

public class Scripture
{
    private string _Sname;//scripture name
    private List<Word> _Obj_word;//scripture long string
    private List<int> usednumbers = new List<int>();


    public Scripture()
    {
        _Sname = "scripture name";
        _Obj_word = new List<Word>();
    }
    public Scripture(string name)
    {
        _Sname = name;
        _Obj_word = new List<Word>();        
    }
    public Scripture(string name, string wholescripture)
    {
        _Sname = name;
        _Obj_word = new List<Word>();
        foreach (string _word in wholescripture.Split(' '))
        {
            _Obj_word.Add(new Word(_word));
        }   
    }
    public string Display_Scripture()
    {
        Console.Write($"{_Sname} ");
        foreach (Word word in _Obj_word)
        {
            if (word.Get_Used() == true)
            {
                Console.Write($"{word.Get_Blankword()} ");
            }
            else
            {
                Console.Write($"{word.Get_Word()} ");
            }

        }

        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("Press enter to continue or type 'quit' to finish: ");
        string _response = Console.ReadLine();
        return _response;
    }
    public void Blank_Scripture_Words()
    {
        for (int i = 0; i < 3; i++)
        {
            //Select which word to replace
            Random randomGenerator = new Random();
            int number = randomGenerator.Next(0, _Obj_word.Count());

            //Check to see if this word/[number] was used already
            bool match = _Obj_word[number].Get_Used();

            if (usednumbers.Count() == _Obj_word.Count())
            {
                return;
            }
            else if (match)
            {
                i--;
            }
            else if (!match)
            {
                usednumbers.Add(number);
                //usednumbers[number]= _Obj_word[number].Count_Word();
                //switch bool used value
                _Obj_word[number].Switch_Bool();
            }
        }
    }
    public string Countusednumbers()//checks to see if there are enough words left to continue
    {
        string responce = "This is a very small local variable, You should not be seeing this.";
        if (usednumbers.Count() == _Obj_word.Count())
        {
            responce = "quit";
        }
        return responce;
    } 
}