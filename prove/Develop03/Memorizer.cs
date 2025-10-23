public class Memorizer
{
    public async Task Start_Memorizer()
    {

        //private local variables
        string _name_chapter_verse;
        SDatabase db;
        Scripture scripture1;
        string _endresponse;
        string _count;

        Console.Clear();
        Console.WriteLine("Which scripture (Only from the Bible) would you like to practise with: ");
        _name_chapter_verse = Console.ReadLine();

        db = new SDatabase(_name_chapter_verse);
        // Load the verse from the online API, into the SDatabase object
        await db.LoadVerseAsync();

        scripture1 = new Scripture(db.Get_Name(), db.Get_Scripture());
        
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