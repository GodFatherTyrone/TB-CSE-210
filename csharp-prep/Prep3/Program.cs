using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");

        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 100);
        Console.WriteLine(number);

        Console.Write("I have made a number between 1 and 100, please guess the number. ");
        string guessS = Console.ReadLine();
        int input = int.Parse(guessS);

        while (input != number)
        {
            if (input < number)
            {
                Console.WriteLine("Too low, go higher");
            }
            else if (input > number)
            {
                Console.WriteLine("Too high, go lower.");
            }
            guessS = Console.ReadLine();
            input = int.Parse(guessS);
        }
        if (input == number)
        { 
            Console.WriteLine("You got it! Good Job!");
        }
    }
}