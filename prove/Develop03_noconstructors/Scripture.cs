using System.Net.Quic;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

public class Scripture
{
    //Private local variables
    private string _scripturename;
    private string _scripture;
    private List<string> scripturewords = new List<string>();
    private List<int> usednumbers = new List<int>();
    
    public void Create_Scripture_List(string choose) //inishalize create list
    {
        if (choose == "1")
        {
            _scripturename = "Romans 8:38-39";
            _scripture = "For I am persuaded, that neither death, nor life, nor angels, nor principalities, nor powers, nor things present, nor things to come, Nor height, nor depth, nor any other creature, shall be able to separate us from the love of God, which is in Christ Jesus our Lord.";
        }
        else if (choose == "2")
        {
            _scripturename = "Alma 37:37";
            _scripture = "Counsel with the Lord in all thy doings, and he will direct thee for good; yea, when thou liest down at night lie down unto the Lord, that he may watch over you in your sleep; and when thou risest in the morning let thy heart be full of thanks unto God; and if ye do these things, ye shall be lifted up at the last day.";
        }
        //Splits the scripture into a list of words called 'scripture words'
        scripturewords.AddRange(_scripture.Split(' '));
    }

    public void Display_Scripturewords()//loops the 'scripture words' list, displays each word
    {
        Console.Write($"{_scripturename} ");
        foreach (string word in scripturewords)
        {
            Console.Write($"{word} ");
        }

        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("Press enter to continue or type 'quit' to finish: ");
    }
    
    public void Blank_Words()//this function blanks three words
    {
        for (int i = 0; i < 3; i++)
        {
            //Select which word to replace
            Random randomGenerator = new Random();
            int number = randomGenerator.Next(0, scripturewords.Count());

            
            bool match= usednumbers.Contains(number);
            if (match)
            {
                i--;
            }
            else if (!match)
            {
                usednumbers.Add(number);

                //Count charcters of the word chosen, create a blank word with the same amount of characters.
                int count = scripturewords[number].Count();
                string _newword = "";

                for (int j = 0; j < count; j++)
                {
                    _newword = _newword + "_";
                }

                scripturewords[number] = _newword;
                //end check (ends the infinate loop)
                if (scripturewords.Count() == usednumbers.Count())
                {
                    return;
                }
            } 
        }
    }
    public string Countusednumbers()//checks to see if there are enough words left to continue
    {
        string responce = "You should not be seeing this.";
        if (scripturewords.Count() == usednumbers.Count())
        {
            responce = "quit";
        }    
        return responce;
    }
    

}