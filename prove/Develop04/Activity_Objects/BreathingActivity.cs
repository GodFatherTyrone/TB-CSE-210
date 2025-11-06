namespace Activity_Objects;
public class BreathingActivity : Activity
{
    public void Start_Breathing_Activity()
    {
        Console.Clear();
        Console.WriteLine("Get Ready...");
        Animate_Spinner(4);
        Console.WriteLine("");
        Console.WriteLine("");

        DateTime _starttime = DateTime.Now;
        DateTime _endtime = _starttime.AddSeconds(Get_Time());
        while (DateTime.Now < _endtime)
        {
            Console.WriteLine("Breathe in...");
            Animate_Countdown(4);
            Console.WriteLine("Now breathe out...");
            Animate_Countdown(4);
            Console.WriteLine("");
        }
    }
}