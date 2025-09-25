using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");

        //asking user to make a list that stops on 0
        List<int> data = new List<int>();
        int input;
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        do
        {
            Console.Write("Enter number: ");
            string guessS = Console.ReadLine();
            input = int.Parse(guessS);
            data.Add(input);

            

        } while (input != 0);
        
        //check to see if the numbers were recorded
        /*
        foreach (int number in data)
        {
            Console.WriteLine(number);
        }
        */

        //this is to find the sum of the list "data"
        int sum = 0;
        foreach (int number in data)
        {
            sum = sum + number;
        }
        Console.WriteLine($"The sum of all the numbers in the data is: {sum}");

        //this is to find the average in the list "data"
        int i = 0;
        float avg = 0;
        foreach (int number in data)
        {
            i++;
        }
        avg = sum / i;
        Console.WriteLine($"The average of the numbers in the data is: {avg}");

        //this is to find the biggest in the list "data"
        int biggest = 0;
        foreach (int number in data)
        {
            if (number > biggest)
            {
                biggest = number;
            }
        }
        Console.WriteLine($"The biggest number in the data is: {biggest}");
        



        /*
        data.Add("phone");
        data.Add("keyboard");
        data.Add("mouse");

        Console.WriteLine(data.Count);

        

        for (int i = 0; i < data.Count; i++)
        {
            Console.WriteLine(data[i]);
        }
        */
    }
}