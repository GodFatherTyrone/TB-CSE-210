using System;

class Program
{
    //I need to separate all things
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep5 World!");
        
        DisplayWelcome();

        string name = PromptUserName();

        int favnumber = PromptUserNumber();

        int square = SquareNumber(favnumber);

        int year;
        PromtUserBirthYear(out year);

        

        DisplayResult(name, square, year);
    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string uname = Console.ReadLine();
        return uname;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favortite number: ");
        string numberS = Console.ReadLine();
        int favnumber = int.Parse(numberS);
        return favnumber;
    }

    static void PromtUserBirthYear(out int year)
    {
        Console.Write("Please enter the year you were born: ");
        string yearS = Console.ReadLine();
        year = int.Parse(yearS);
    }

    static int SquareNumber(int favnumber)
    {
        int square = favnumber * favnumber;
        return square;
    }

    static void DisplayResult(string name, int square, int year)
    {
        Console.WriteLine($"{name}, the square of your favorite number is {square}");
        Console.WriteLine($"{name}, you will turn {2025 - year} this year");
    }
}