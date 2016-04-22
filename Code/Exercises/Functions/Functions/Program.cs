using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = a;
            a = 5;
            Console.WriteLine(b);

            int number = 1;
            GetNumber(number);
            Console.WriteLine(number);
            Console.WriteLine("2 + 3 = " + add(2, 3));
            PrintWhatISay("Test");
            
            Console.WriteLine("Now I'm going to request a number.");
            int j = GetMeANumber();
            Console.WriteLine("Your number is " + j);
            Console.ReadLine();
        }

        static int add(int x, int y)
        {
            return x + y;
        }

        static void GetNumber(int number)
        {
            // console.readline
            // parse
            number = 10; // number = Convert.ToInt16(answer)
        }

        static void PrintHi()
        {
            PrintWhatISay("Hi");
        }

        static string ReturnHi()
        {
            return "Hi";
        }

        static void PrintWhatISay(string print)
        {
            Console.WriteLine(print);
        }

        static int GetMeANumber()
        {
            bool loop = true;
            int number = 0;
            while (loop)
            { 
                Console.WriteLine("Type in a number");
                string answer = Console.ReadLine();
                if (int.TryParse(answer, out number))
                {
                    loop = false; // not needed because return leaves a function immediately
                    // return number;
                }
            }
            return number;

            
        }
    }
}
