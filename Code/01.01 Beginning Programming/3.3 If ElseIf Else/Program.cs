using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElseIfElse
{
    class Program
    {
        static void Main(string[] args)
        {
            string words = "some words";

            if (words.Length > 5)
            {
                Console.WriteLine("More than 5");
            }
            if (words.Length > 7)
            {
                Console.WriteLine("More than 7");
            }

            Console.WriteLine("What about if and else?");

            if (words.Length > 5)
            {
                Console.WriteLine("More than 5");
            }
            else if(words.Length > 7)
            {
                Console.WriteLine("More than 7");
            }
            else
            {
                Console.WriteLine("Not more than 5 or 7");
            }


            Console.ReadLine();

            // How can the if else/if make sense and work the way you would expect (ie, if it is more than 7, show that, if it is between 5-7, show more than 5)



            var value = "some string";

            switch (value)
            {
                case "one":
                case "two":
                    Console.WriteLine("it equals one or two");
                    break;
                case "three":
                    Console.WriteLine("how about three?");
                    break;
                default:
                    Console.WriteLine("it equals something else");
                    break;
            } 
        }
    }
}
