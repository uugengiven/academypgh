using System;


namespace BasicMath
{
    class Program
    {
        static void Main(string[] args)
        {

            // Here are a few simple math equations
           
            Console.WriteLine(2 + 3);
            Console.WriteLine(2 * 3);

            Console.WriteLine(2 + 2 * 8); // * first then the +
            Console.WriteLine((2 + 2) * 8); // () first then the *

            // Console.WriteLine(3 / 2 * 4); // what will happen here?
            Console.WriteLine(3 / (2 * 4)); // and here?
            

            Console.ReadLine();

        }
    }
}
