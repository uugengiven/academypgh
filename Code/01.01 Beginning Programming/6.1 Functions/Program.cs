using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._1_Functions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two numbers and I'll multiply them!");
            //int number1 = GetAnswer();
            //int number2 = GetAnswer();

            Console.WriteLine("Your answer is: " + GetAnswer() * GetAnswer());
            Console.ReadLine();
        }

        static int Multiply(int x, int y)
        {
            return (x * y);
        }

        static int GetAnswer()
        {
            Console.WriteLine("What is your number?");
            int answer = Convert.ToInt32(Console.ReadLine());

            return answer;
        }
    }
}
