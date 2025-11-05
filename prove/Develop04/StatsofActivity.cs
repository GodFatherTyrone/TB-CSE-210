using System.Diagnostics;
using System.IO.Enumeration;

public class StatsofActivity
{
    private List<int> _stats = new List<int> { 0, 0, 0 };
    string _filename;
    public void Load_Stats()
    {
        Console.Clear();
        Console.WriteLine("");
        Console.WriteLine("What name should I load for? (case sensitive, no spaces): ");
        string _personname = Console.ReadLine();
        Console.WriteLine("");
        _filename = "ActivityStats_" + _personname + ".txt";
        if (File.Exists(_filename))
        {
            // Read all lines into array of strings
            string[] lines = File.ReadAllLines(_filename);
            int i = 0;
            foreach (string line in lines)
            {
                //convert to int and add
                if (int.TryParse(line, out int value))
                {
                    _stats[i] = value;
                    i++;
                }
            }
            Console.WriteLine("");
            Console.WriteLine($"Successfully loaded stats from [{_filename}]");
        }
        else
        {
            Console.WriteLine($"File not found: [{_filename}]");
        }
    }
    public void Save_Stats()
    {
        Console.Clear();
        Console.WriteLine("");
        Console.WriteLine("What name should I save into? (case sensitive, no spaces)");
        string _personname = Console.ReadLine();
        _filename = "ActivityStats_" + _personname + ".txt";
        using (StreamWriter writer = new StreamWriter(_filename))
        {
            foreach (int value in _stats)
            {
                writer.WriteLine(value);
            }
        }
        Console.WriteLine($"Successfully saved stats to [{_filename}]");
        Console.WriteLine("Thank you for using this program!");
        Console.WriteLine("");
        Console.WriteLine("Goodbye!");
        Console.WriteLine("");
    }
    public int GetStats_Reflecting()
    {
        return _stats[0];
    }
    public int GetStats_Listing()
    {
        return _stats[1];
    }
    public int GetStats_Breathing()
    {
        return _stats[2];
    }
    public void Add_Stats(string whichone)
    {
        int i = int.Parse(whichone)-1;
        _stats[i] =_stats[i] + 1;
    }
    public void Display_Stats()
    {
        Console.WriteLine("");
        Console.WriteLine("You have used the Activity program for,");
        Console.WriteLine("");
        Console.WriteLine($"Reflecting: {_stats[0]} times");
        Console.WriteLine($"Listing: {_stats[1]} times");
        Console.WriteLine($"Breathing: {_stats[2]} times");
        Console.WriteLine("");
    }
}