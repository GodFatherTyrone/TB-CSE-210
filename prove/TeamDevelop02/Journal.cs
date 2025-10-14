using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class Journal
{

    public List<Entry> _entries = new List<Entry>();
    string menuresponse;
    string filePath;

    public void StartJournal()
    {
        Console.WriteLine("");
        Console.WriteLine("Welcome to your journal, please choose one of the options using the number. ");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Save");
        Console.WriteLine("4. Load");
        Console.WriteLine("5. Quit");

        menuresponse = Console.ReadLine();

        if (menuresponse == "1") //Write
        {
            Entry entry1 = new Entry();
            Console.WriteLine($"{entry1._date}\nPrompt: {entry1._prompt}");
            string response1 = Console.ReadLine();
            entry1._response = response1;
            _entries.Add(entry1);

            StartJournal();
        }
        else if (menuresponse == "2") //Display List
        {
            DisplayEntries();
            StartJournal();
        }
        else if (menuresponse == "3") //Save
        {
            Console.WriteLine("Enter the name of your file: ");
            string filename = Console.ReadLine();

            using (StreamWriter outputFile = new StreamWriter(filename))
            {
                foreach (Entry entry in _entries)
                    outputFile.WriteLine(entry.ToLine());
            }

            Console.WriteLine($"{filename} has been successfully saved! ");
            StartJournal();
        }
        else if (menuresponse == "4") //Load
        {
            LoadsFile();
            StartJournal();
        }
        else if (menuresponse == "5") //Quit
        {
            Console.WriteLine("Good Bye");
        }
        else //Restart
        {
            Console.WriteLine("try again");
            StartJournal();
        }
    }//End of StartJournal


    public void DisplayEntries()
    {
        foreach (Entry _entry in _entries)
        {
            Console.WriteLine($"{_entry}");
        }
    }

    public void LoadsFile()
    {
        Console.WriteLine($"Enter the path of the file");
        filePath = Console.ReadLine();

        // Read all lines from the file into a string array
        string[] linesArray = File.ReadAllLines(filePath);

        //convert string to Fromline() format, then add entrys to _entries List
        _entries = linesArray.Select(line => Entry.FromLine(line)).ToList();

        // Convert the string array to a List<string>
        //_entries = linesArray.ToList();

    }
}
// load, display, write, save, quit