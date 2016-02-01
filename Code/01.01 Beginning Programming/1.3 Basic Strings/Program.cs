using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            // What happens if we pretend strings can use math?

            Console.WriteLine("Hello" + "World");
            Console.WriteLine("Hello" + 2);
            Console.WriteLine("Hello" + 2 / 2 + "World");
            Console.WriteLine("Hello" + 2 + 2 + "World"); // What happened?

            // Turns out we don't need to pretend
            // What else can strings do?

            //Console.WriteLine("Hello World".Length);
            //Console.WriteLine("Hello World".ToUpper());

            //Console.WriteLine("Hello World".Replace("World", "Universe"));

            Console.ReadLine();
        }
    }
}

/*
**********************
    Strings can be combined, taken apart, formatted and more -  right now we are talking about combining (concatenation)

    + lets you put two strings together
    Much like with our integer example earlier, there is an implicit conversion when adding a string and integer together

    Again, order of operations is important when you look at integer and string addition

    Strings are special as they are an object, not a value type
    This means you can access extra parts of a string, such as .Length
    This is the same as when we're typing Console.WriteLine
**********************
*/
