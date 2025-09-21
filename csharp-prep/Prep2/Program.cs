using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");

        Console.Write("What score did you get? ");
        string scoreS = Console.ReadLine();

        //int score = scoreS.ToString();

        int score = int.Parse(scoreS);

        string letter = "Unknown";
        bool stat = true;
        if (score > 90)
        {
            letter = "A";
        }
        else if (score >= 80)
        {
            letter = "B";
        }
        else if (score >= 70)
        {
            letter = "C";
        }
        else if (score >= 60)
        {
            letter = "D";
        }
        else if (score < 60)
        {
            letter = "F";
        }
        else
        {
            stat = false;
            Console.WriteLine("I don't know what to do with that?");
        }


        if (stat == true)
        {
            Console.WriteLine($"You got an {letter}");
        }
        
        if (score >= 60)
            {
                Console.WriteLine("You passed Good Job");
            }
            else if (score < 60)
            {
                Console.WriteLine("you failed, try again");
            }
        
    }
}