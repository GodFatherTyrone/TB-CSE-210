using System;
using System.Formats.Asn1;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop04 World!");

        
        Console.WriteLine("Time to calm down!");
        Console.Clear();
        Ask_For_Activity();
    }
    
    static private void Ask_For_Activity()
    {
        StatsofActivity stats1 = new StatsofActivity();
        string _answer;
        do
        {   
            Console.WriteLine("What activity would you like to participate in?: ");
            Console.WriteLine("     1.  Start Reflecting Activity");
            Console.WriteLine("     2.  Start Listing Activity");
            Console.WriteLine("     3.  Start Breathing Activity");
            Console.WriteLine("     4.  Load my Stats");
            Console.WriteLine("     5.  Save & Quit");
            Console.WriteLine("");
            Console.Write("Select a choice from the menu above: ");
            _answer = Console.ReadLine();
            
            if (_answer == "1")
            {
                stats1.Add_Stats(_answer);
                ReflectingActivity activity1 = new ReflectingActivity();
                activity1.Set_Activity(//title, instructions 
                    "Reflecting Activity",
                    "This activity will help you reflect on the times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life."
                    );
                activity1.Display_Activity();
                activity1.Set_Time();
                activity1.Start_Reflecting_Activity();
                Console.WriteLine("");
                activity1.Display_End_Messsage();
                stats1.Display_Stats();
            }
            else if (_answer == "2")
            {
                stats1.Add_Stats(_answer);
                ListingActivity activity2 = new ListingActivity();
                activity2.Set_Activity(//title, instructions 
                    "Listing Activity",
                    "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area."
                    );
                activity2.Display_Activity();
                activity2.Set_Time();
                activity2.Start_Listing_Activity();
                activity2.Display_End_Messsage();
                stats1.Display_Stats();
            }
            else if (_answer == "3")
            {
                stats1.Add_Stats(_answer);
                BreathingActivity activity3 = new BreathingActivity();
                activity3.Set_Activity(//title, instructions 
                    "Breathing Activity",
                    "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing."
                    );
                activity3.Display_Activity();
                activity3.Set_Time();
                activity3.Start_Breathing_Activity();
                Console.WriteLine("");
                activity3.Display_End_Messsage();
                stats1.Display_Stats();
            }
            else if (_answer == "4")//load
            {
                stats1.Load_Stats();
                stats1.Display_Stats();
            }
            else if (_answer == "5")//save&quit
            {
                stats1.Save_Stats();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Sorry, I didn't quite catch that? Please try again:");
                Console.WriteLine("");
            }
        } while (_answer != "5");
    }
}