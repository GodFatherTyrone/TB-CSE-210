using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop03 World!");

        Memorizer memorizer1 = new Memorizer();
        memorizer1.StartMemorizer()
    }
}
/*
Design Requirements
In addition your program must:
    1.Use the principles of Encapsulation, including proper use of classes, methods, public/private access modifiers, and follow good style throughout.
    2.Contain at least 3 classes in addition to the Program class: one for the scripture itself, one for the reference (for example "John 3:16"), and to represent a word in the scripture.
    3.Provide multiple constructors for the scripture reference to handle the case of a single verse and a verse range ("Proverbs 3:5" or "Proverbs 3:5-6").
*/

/*
To Do:
Add another class:
    -Move some stuff around
    -scripture finder?
        -Package ‘scriptuRs’ or "https://github.com/andrewheiss/scriptuRs"
Add multiple constrictors:
    -idk
*/

/*
I was able to make the randome generater not blank the same words again.
*/