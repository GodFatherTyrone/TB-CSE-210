using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning04 World!");
        Console.Clear();

        Assignment assignment1 = new Assignment("Samuel Bennett", "Multiplication");
        Console.WriteLine(assignment1.Get_Summary());
        Console.WriteLine("");

        Math_Assignment math_assignment1 = new Math_Assignment("Roberto Rodriguez", "Fractions", "Section 7.3", "Problems 8-19");
        Console.WriteLine(math_assignment1.Get_Summary());
        Console.WriteLine(math_assignment1.Get_Homeworklist());
        Console.WriteLine("");

        Writing_Assignment writing_assignment1 = new Writing_Assignment("Mary Waters", "European History", "The Causes of World War II by Mary Waters");
        Console.WriteLine(writing_assignment1.Get_Summary());
        Console.WriteLine(writing_assignment1.Get_Writing_Information());
        Console.WriteLine("");
    }
}
