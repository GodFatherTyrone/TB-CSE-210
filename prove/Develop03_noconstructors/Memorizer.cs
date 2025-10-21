public class Memorizer
{
    public void StartMemorizer()
    {
        //private local variables
        string _endresponse;
        string _count;
        

        Console.Clear();
        //choose scriptures function/class
        Console.WriteLine("Which scriptures would you like to practise with: ");
        Console.WriteLine("1. Romans 8:38-39");
        Console.WriteLine("2. Alma 37:37");
        Console.WriteLine("Please enter a number: ");
        string _whichscripture = Console.ReadLine();

        //Splits the scripture chosen into a list of words
        Scripture scripture1 = new Scripture(/**/);
        scripture1.Create_Scripture_List(_whichscripture);
        
        Console.Clear();
        //loop intill response is "quit"
        do
        {
            //display list of scripture words
            scripture1.Display_Scripturewords();

            //saves if want to quit
            _endresponse = Console.ReadLine();

            //word number check (Have we run out of words in the scripture?)
            _count = scripture1.Countusednumbers();

            //if there are more words, continue to blank more
            if (_count != "quit")
            {
                scripture1.Blank_Words();
            }
            Console.Clear();

            //checks if the user or the program says to quit
        } while (_endresponse != "quit" && _count != "quit");
    }
}