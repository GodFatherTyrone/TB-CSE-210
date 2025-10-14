using System;

public class Entry
{
    static Prompts prompt1 = new Prompts();
    // static string _prompts = prompt1.RandomizePrompt();
    static DateTime theCurrentTime = DateTime.Now;
    static DateTime datePartOnly = theCurrentTime.Date;


    public string _date { get; set; } = datePartOnly.ToString("MM/dd/yyyy");
    public string _prompt { get; set; } = prompt1.RandomizePrompt();
    public string _response { get; set; } = "";




    public override string ToString()
        => $"[{_date}] {_prompt}\n{_response} \n"; //this formats what we see when the prompt appears...

    public string ToLine() => $"{_date}|{_prompt}|{_response}";

    public static Entry FromLine(string line)
    {
        var parts = line.Split('|');
        if (parts.Length < 3) return new Entry(); //For my info: this will help the program not to crash if by any reason, there are less than 3 parts on the entry. 
        return new Entry
        {
            _date = parts[0],
            _prompt = parts[1],
            _response = parts[2]
        };
    }
}

