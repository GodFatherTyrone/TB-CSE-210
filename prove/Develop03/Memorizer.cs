public class Memorizer
{
    public async Task Start_Memorizer()
    {
        //private local variables
        string _name_chapter_verse;
        Scripture scripture1;
        string _endresponse;
        string _count;

        Console.Clear();
        Console.WriteLine("Which scriptures (From the Bible or Book of Mormon) would you like to practice with? ");
        Console.WriteLine("Example: 'John 1:1' or 'John 1:1-21': ");
        _name_chapter_verse = Console.ReadLine();

        scripture1 = new Scripture(_name_chapter_verse);
        await scripture1.Load_Scripture_From_Name();

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