namespace Activity_Objects;
public class Activity
{
    private string _title = "Unchanged";
    private string _instructions = "Unchanged";
    private int _time_seconds = 5;

    //startmessage, instructions, endmessage; time
    public int Get_Time()
    {
        return _time_seconds;
    }
    public void Set_Activity(string title, string instructions)
    {
        _title = title;
        _instructions = instructions;
    }
    public void Set_Time()
    {
        int _int_seconds = 5;
        while (true)
        {
            Console.WriteLine("How many seconds would you like this exercise to be?");
            string _str_seconds = Console.ReadLine();

            if (int.TryParse(_str_seconds, out _int_seconds))
            {
                break;
            }
            else
            {
                Console.WriteLine("That's not a valid number.");
            }
        }
        _time_seconds = _int_seconds;
    }
    public void Display_Activity()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_title}");
        Console.WriteLine("");
        Console.WriteLine(_instructions);
        Console.WriteLine("");
    }

    private List<string> _animationstrings = new List<string> { "|", "/", "-", "\\" };
    public void Animate_Spinner(int seconds)
    {
        DateTime _starttime = DateTime.Now;
        DateTime _endtime = _starttime.AddSeconds(seconds);
        int i = 0;
        while (DateTime.Now < _endtime)
        {
            string s = _animationstrings[i];
            Console.Write(s);
            Thread.Sleep(300);
            Console.Write("\b \b");
            i++;
            if (i >= _animationstrings.Count)
            {
                i = 0;
            }
        }
    }
    public void Animate_Countdown(int seconds)
    {
        for (int i = seconds; i > 0; i--) //counts down (per sec) from i
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
    public void Animate_Dots(int seconds)
    {
        DateTime _starttime = DateTime.Now;
        DateTime _endtime = _starttime.AddSeconds(seconds);
        int i = 0;
        while (DateTime.Now < _endtime)
        {
            Console.Write(".");
            Thread.Sleep(1000);
            i++;
        }
    }
    public void Display_End_Messsage()
    {
        Console.WriteLine("Well done!!");
        Animate_Spinner(5);
        Console.WriteLine("");
        Console.WriteLine($"You have completed another activity! This {_title} was used for {_time_seconds} seconds.");
        Animate_Spinner(10);
        Console.Clear();
    }
}