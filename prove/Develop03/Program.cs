using System;
using System.Runtime.InteropServices;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text.Json;

class Program
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("Hello Develop03 World!");

        Memorizer memorizer1 = new Memorizer();
        await memorizer1.Start_Memorizer();
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
I was able to make the randome generater not be able to choose the same word twice.
I was able to get an api to get the scripture needed. 
*/