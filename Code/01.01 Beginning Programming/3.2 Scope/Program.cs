using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scope
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            if (a < 30)
            {
                int b = 6;
                a = b;
            }
            
            if ((a % 2) == 0)
            {
                int b = 13;
                a = b;
            }

            Console.WriteLine("a = " + a);
            //Console.WriteLine("b = " + b);

            Console.ReadLine();
        }
    }
}
