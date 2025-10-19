public class Memorizer
{
    public void StartMemorizer()
    {
        string _endresponse;
        string _count;
        Scripture scripture1 = new Scripture();

        Console.Clear();
        //choose scriptures function/class
        Console.WriteLine("Which scriptures would you like to practise with: ");
        Console.WriteLine("1. Romans 8:38-39");
        Console.WriteLine("2. Alma 37:37");
        Console.WriteLine("Please enter a number: ");
        string _whichscripture = Console.ReadLine();
        scripture1.Create_Scripture_List(_whichscripture);
        Console.Clear();
        
        //loop intill response is "quit"
        do
        {
            //display list of scripture words
            scripture1.Display_Scripturewords();

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Press enter to continue or type 'quit' to finish: ");
            _endresponse = Console.ReadLine();

            //wordcheck
            _count = scripture1.Countusednumbers();
            if (_count != "quit")
            {
                scripture1.Blank_Words();
            }
            Console.Clear();
        } while (_endresponse != "quit" && _count != "quit");
    }
}