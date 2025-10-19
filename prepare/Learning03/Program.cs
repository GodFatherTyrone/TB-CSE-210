using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning03 World!");

        /* Person example
        old example
        Person p = new Person();
        p.SetFirstName("Peter");
        Console.WriteLine(p.GetFirstName());

        new example
        Person p1 = new Person(); // Don't pass any information to get the default values
        Person p2 = new Person("Jane", "Doe"); // pass the first and last names
        Person p3 = new Person("Mrs.", "Jane", "Doe"); // pass all three variables
        */

        Fraction F1 = new Fraction();
        Fraction F2 = new Fraction(6);
        Fraction F3 = new Fraction(6, 7);

        Fraction Fsg = new Fraction();
        Fsg.SetNumerator(12);
        Console.WriteLine(Fsg.GetNumerator());

        Fsg.SetDenominator(3);
        Console.WriteLine(Fsg.GetDenominator());

        Fraction Ffs = new Fraction(3, 4);
        Console.WriteLine(Ffs.GetFractionString());

        Console.WriteLine(Ffs.GetDecimalValue());

        Console.WriteLine("");
        Console.WriteLine("This is what you want to see:");
        Console.WriteLine(F1.GetFractionString());
        Console.WriteLine(F1.GetDecimalValue());

        Fraction F4 = new Fraction(5);
        Console.WriteLine(F4.GetFractionString());
        Console.WriteLine(F4.GetDecimalValue());

        Console.WriteLine(Ffs.GetFractionString());
        Console.WriteLine(Ffs.GetDecimalValue());

        Fraction F5 = new Fraction(1, 3);
        Console.WriteLine(F5.GetFractionString());
        Console.WriteLine(F5.GetDecimalValue());


    }
}