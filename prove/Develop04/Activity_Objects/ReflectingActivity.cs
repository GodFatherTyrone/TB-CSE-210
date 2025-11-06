using System.Diagnostics.CodeAnalysis;
namespace Activity_Objects;

public class ReflectingActivity : Activity
{
    private List<string> _rprompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };
    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };
    public string Get_Reflecting_Prompt()
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, _rprompts.Count);
        return _rprompts[number];
    }
    public string Get_Reflecting_Question()
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, _questions.Count);
        return _questions[number];
    }
    public void Start_Reflecting_Activity()
    {
        Console.Clear();
        Console.WriteLine("Get Ready...");

        Animate_Spinner(4);
        

        Console.WriteLine("Consider the following prompt: ");
        Console.WriteLine("");
        Console.WriteLine($" --- {Get_Reflecting_Prompt()} --- ");
        Console.WriteLine("");
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();

        Console.Clear();
        DateTime _starttime = DateTime.Now;
        DateTime _endtime = _starttime.AddSeconds(Get_Time());
        while (DateTime.Now < _endtime)
        {
            Console.WriteLine($"> {Get_Reflecting_Question()}");
            Animate_Spinner(10);
        }
        Console.WriteLine("");
    }
}
        // for (int i = 5; i>0; i--) //counts down (per sec) from i
        // {
        //     Console.Write(i);
        //     Thread.Sleep(1000);
        //     Console.Write("\b \b");
        // }