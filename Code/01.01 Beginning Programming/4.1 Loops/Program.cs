using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            if (true)
            {
                Console.WriteLine("This will happen once.");
            }

            while (true)
            {
                Console.WriteLine("This will happen over and over, forever.");
                // try to not do this
                // but you /can/ get out of this with a break statement
                break;
            }
           


            //exercise stuff

            var conditional = true;
            var i = 0;
            while (conditional)
            {
                Console.WriteLine("The value of i is " + i);
                i = i + 1;
                if (i > 10)
                {
                    conditional = false;
                }
            }

            conditional = true;
            var input = "";
            while (conditional)
            {
                Console.WriteLine("I will repeat until you type: stop");
                input = Console.ReadLine();
                if (input == "stop")
                {
                    conditional = false;
                }
            }



            Console.ReadLine();
        }
    }
}
