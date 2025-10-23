public class Memorizer
{
    public void StartMemorizer()
    {
        //private local variables
        string _endresponse;
        string _count;
        Scripture scripture1;

        Console.Clear();
        
        //choose scriptures function/class
        Console.WriteLine("Which scriptures would you like to practise with: ");
        Console.WriteLine("1. Romans 8:38-39");
        Console.WriteLine("2. Alma 37:37");
        Console.WriteLine("Please enter a number: ");
        string _whichscripture = Console.ReadLine();


        //Splits the scripture chosen into a list of words
        if (_whichscripture == "1")
        {
            scripture1 = new Scripture("Romans 8:38-39", "For I am persuaded, that neither death, nor life, nor angels, nor principalities, nor powers, nor things present, nor things to come, Nor height, nor depth, nor any other creature, shall be able to separate us from the love of God, which is in Christ Jesus our Lord.");
        }
        else if (_whichscripture == "2")
        {
            scripture1 = new Scripture("Alma 37:37", "Counsel with the Lord in all thy doings, and he will direct thee for good; yea, when thou liest down at night lie down unto the Lord, that he may watch over you in your sleep; and when thou risest in the morning let thy heart be full of thanks unto God; and if ye do these things, ye shall be lifted up at the last day.");
        }
        else
        {
            Console.WriteLine("Goodbye ");
            return;
        }
        
        Console.Clear();
        //loop intill response is "quit"
        do
        {
            //display list of scripture words & returns if they want to quit
            _endresponse = scripture1.Display_Scripture();
            //Prompt Stop


            //word number check (Have we run out of words in the scripture?)
            _count = scripture1.Countusednumbers();

            //if there are more words, continue to blank more
            if (_count != "quit")
            {
                scripture1.Blank_Scripture_Words();
            }
            Console.Clear();

            //checks if the user or the program says to quit
        } while (_endresponse != "quit" && _count != "quit");
    }
}