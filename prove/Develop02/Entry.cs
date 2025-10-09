using System.Diagnostics.CodeAnalysis;

public class Entry
{
    public string StartEntry(out string _fulentry)
    {
        /*
        -get date from computer
        -display it
        */

        DateTime _currentDateAndTime = DateTime.Now;

        Console.WriteLine($"it is currently {_currentDateAndTime}");

        /*turn the date time to a string to at to the entry (I dont know if this in needed)*/

        /*string _currentdateS = string.Parse(_currentDateAndTime);*/

        /*
        -Grab prompt from function/class Prompt()
        -Display prompt and collect entry
        -combine the date and the entry
        */

        Prompts prompt1 = new Prompts();
        string chosenP;
        string _prompt = prompt1.ReturnPrompts(out chosenP);

        Console.WriteLine($"{_prompt}");
        string _entry = Console.ReadLine();

        _fulentry = _currentDateAndTime + " " + _entry;

        /*add this _fulentry to it as one string*/

        return _fulentry;

    }
    /*
    public void DisplayEntry()
    {

    }
    public void SaveEntry()
    {

    }
    public void LoadEntry()
    {
        
    }
    */
}
