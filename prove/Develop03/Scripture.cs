using System.Net.Quic;
using System.Runtime.InteropServices;

public class Scripture
{
    private string _scripturename;
    private string _scripture;
    private List<string> scripturewords = new List<string>();
    private List<int> usednumbers = new List<int>();

    public void Create_Scripture_List(string choose) //inishalize create list
    {
        if (choose == "1")
        {
            //Romans 8:38-39,
            _scripturename = "Romans 8:38-39";
            // 38 For I am persuaded, that neither death, nor life, nor angels, nor principalities, nor powers, nor things present, nor things to come, 
            // 39 Nor height, nor depth, nor any other creature, shall be able to separate us from the love of God, which is in Christ Jesus our Lord.
            _scripture = "For I am persuaded, that neither death, nor life, nor angels, nor principalities, nor powers, nor things present, nor things to come, Nor height, nor depth, nor any other creature, shall be able to separate us from the love of God, which is in Christ Jesus our Lord.";
        }
        else if (choose == "2")
        {
            _scripturename = "Alma 37:37";
            _scripture = "Counsel with the Lord in all thy doings, and he will direct thee for good; yea, when thou liest down at night lie down unto the Lord, that he may watch over you in your sleep; and when thou risest in the morning let thy heart be full of thanks unto God; and if ye do these things, ye shall be lifted up at the last day.";
        }
        scripturewords.AddRange(_scripture.Split(' '));
    }
    public void Display_Scripturewords()
    {
        Console.Write($"{_scripturename} ");
        foreach (string word in scripturewords)
        {
            Console.Write($"{word} ");
        }
    }
    
    public void Blank_Words()
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
            //end check
            if (scripturewords.Count() == usednumbers.Count())
            {
                return;
            }
            } 
        }
    }
    public string Countusednumbers()
    {
        string responce = "You should not be seeing this.";
        if (scripturewords.Count() == usednumbers.Count())
        {
            responce = "quit";
        }    
        return responce;
    }
    

}