using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToRomanNumerals
{
    class Program
    {
        static void Main(string[] args)
        {

            // Ask the user for a number
            // Display that number in roman numerals
            // Ex
            // Enter a number:
            // 19
            // Your number in Roman Numerals is XIX


            // I = 1
            // V = 5
            // X = 10
            // L = 50
            // C = 100
            // D = 500
            // M = 1000

            // 4 = IV
            // 9 = IX
            // 8 = VIII
            // 80 = LXXX
            // 139 = CXXXIX
            // 40 = XL

            Console.WriteLine("Enter a number");
            string answer = Console.ReadLine();
            int number = Convert.ToInt16(answer) ;

            while (number >= 50)
            {
                Console.Write("L");
                number -= 50;
            }
            while (number >= 10)
            {
                Console.Write("X");
                number = number - 10;
            }
            while (number >= 5)
            {
                Console.Write("V");
                number -= 5;
            }
            while (number >= 4)
            {
                Console.Write("IV");
                number -= 4;
            }
            while (number >= 1)
            {
                Console.Write("I");
                number -= 1;
            }

            Console.ReadLine();
        }
    }
}
