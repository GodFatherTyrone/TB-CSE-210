using System.Formats.Asn1;

public class Scripture
{

    private string _Sname;//scripture name
    SDatabase API1;
    private List<Word> _Obj_word;//scripture long string
    private List<int> _usednumbers = new List<int>();


    public Scripture()
    {
        _Sname = "scripture name";
        _Obj_word = new List<Word>();
    }
    //If only name then collect from api
    public Scripture(string name)
    {
        _Sname = name;
        _Obj_word = new List<Word>();
    }
    public async Task Load_Scripture_From_Name()
    {
        API1 = new SDatabase(_Sname);//Creates an Object with the given name.

        Console.WriteLine("");
        Console.WriteLine("Which book is your selected scripture from? ");
        Console.WriteLine("Write 'Bible' or 'BoM': ");

        string _book = Console.ReadLine();
        if (_book == "Bible")
        {
            await API1.LoadBibleVerseAsync(); //runs the bible api on the SDatabase Object, that should have gotten an name.
        }
        else if (_book == "BoM")
        {
            await API1.LoadBookofMormonVerseAsync(); //runs the BoM api on the SDatabase Object, that should have gotten an name.
        }
        else
        {
            Console.WriteLine("try again");
            await Load_Scripture_From_Name();
        }
        

        string _wholescripture = API1.Get_Scripture();
        foreach (string _word in _wholescripture.Split(' '))
        {
            _Obj_word.Add(new Word(_word));
        }
    }
    //If both name and scripture
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
            Console.Write($"{word.Get_Word()} ");
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

            if (_usednumbers.Count() == _Obj_word.Count())
            {
                return;
            }
            else if (match)
            {
                i--;
            }
            else if (!match)
            {
                _usednumbers.Add(number);
                //usednumbers[number]= _Obj_word[number].Count_Word();
                //switch bool used value
                _Obj_word[number].Switch_Bool();
            }
        }
    }
    public string Countusednumbers()//checks to see if there are enough words left to continue
    {
        string responce = "This is a very small local variable, You should not be seeing this.";
        if (_usednumbers.Count() == _Obj_word.Count())
        {
            responce = "quit";
        }
        return responce;
    } 
}