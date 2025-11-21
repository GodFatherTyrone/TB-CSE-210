using System.ComponentModel.Design;
using System.Diagnostics;
using System.Xml.Linq;

public class Journal
{
    
    public List<string> entrylist = new List<string>();
    string responce;
    string filePath;
    public void StartJournal()
    {
        bool keepLooping = true;
        while (keepLooping)
        {
            Console.WriteLine("");
            Console.WriteLine("You are in your Journal, what would you like to do? ");
            Console.WriteLine("(Enter the number associated with what you want to do.) ");
            Console.WriteLine("0. HELP");
            Console.WriteLine("1. Load");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Write");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.WriteLine("Please give your responce: ");

            responce = Console.ReadLine();

            if (responce == "0" || responce == "HELP") //Works
            {
                /*Help*/
                Help_Explanation();
            }
            else if (responce == "1" || responce == "Load") //works
            {
                /*Loadtextfile*/
                Load_File_To_List();
            }
            else if (responce == "2" || responce == "Display") //works
            {
                /*Displayfiletext*/
                foreach (string _entry in entrylist)
                {
                    Console.WriteLine($"{_entry}");
                }
            }
            else if (responce == "3" || responce == "Write")//works
            {
                /*Write*/
                /*calls StartEntry() from the entry class, returns the entry*/
                Entry entry1 = new Entry();
                string _fulentry = entry1.StartEntry(out _fulentry);

                /*adds returned entry to list*/
                entrylist.Add($"{_fulentry}");
            }
            else if (responce == "4" || responce == "Save")//works
            {
                /*Savenewtextfile*/
                Save_File_To_List();
            }
            else if (responce == "5" || responce == "Quit")//Works
            {
                /*Quit*/
                keepLooping = false;
            }
            else                                           // Works
            {
                /*If provided unknown responce, restart*/
                Console.WriteLine("");
                Console.WriteLine("Sorry, I didn't quite catch that. ");
            }
        }
    }//End of StartJournal()
    public void Help_Explanation()
    {
        /*describe what each choice does*/
        Console.WriteLine("");
        Console.WriteLine("This is an explination of all your options.");
        Console.WriteLine("1. Load: Asks for a file path to load into a present List.");
        Console.WriteLine("2. Display: Displays the List currently loaded.");
        Console.WriteLine("3. Write: Displays a prompt and lets you write a new entry into the local list.");
        Console.WriteLine("4. Save: Asks for a file path to save the present List into a new file.");
        Console.WriteLine("5. Quit: Ends the program");
    }
    public void Load_File_To_List()
    {
        Console.WriteLine($"Please input the filepath.");
        filePath = Console.ReadLine();

        try
        {
            // Read all lines from the file into a string array
            string[] linesArray = File.ReadAllLines(filePath);

            // Convert the string array to a List<string>
            entrylist = linesArray.ToList();
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine($"Error: The file '{filePath}' was not found.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }
    public void Save_File_To_List()
    {
        Console.WriteLine($"Please input the filepath.");
        filePath = Console.ReadLine();

        try
        {
            File.WriteAllLines(filePath, entrylist);
            Console.WriteLine($"List successfully saved to {filePath}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }
}
