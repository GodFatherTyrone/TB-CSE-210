namespace Activity_Objects;
public class ListingActivity : Activity
{
    private List<string> _lprompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };
    public string Get_Listing_Prompt()
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, _lprompts.Count);
        return _lprompts[number];
    }
    private List<string> _lanswers = new List<string>();
    public void Start_Listing_Activity()
    {
        Console.Clear();
        Console.WriteLine("Get Ready...");
        Animate_Spinner(4);

        Console.WriteLine("List as many responses you can to the following prompt: ");
        Console.WriteLine($" --- {Get_Listing_Prompt()} --- ");
        Console.WriteLine("You may begin in: ");
        Animate_Countdown(5);
        Console.WriteLine("Start:");

        DateTime _starttime = DateTime.Now;
        DateTime _endtime = _starttime.AddSeconds(Get_Time());
        while (DateTime.Now < _endtime)
        {
            Console.Write($"> ");
            string _answer = Console.ReadLine();
            _lanswers.Add(_answer);
        }

        Console.WriteLine($"You listed {_lanswers.Count()} items!");
        Console.WriteLine("");
    }
}