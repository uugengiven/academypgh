using System;

namespace FieldPainting
{
    class Program
    {
        static void Main(string[] args)
        {
            // You are helping with a local soccer league
            // They need to be able to paint their fields
            // to mark the center circle. Different leagues
            // have different sized circles, however. Make
            // a program that will ask for the size of the
            // circle and then tell them how much paint they
            // need to cover the center circle. The paint
            // they use covers about 100 sq ft per bucket.
            // Make sure they have enough paint, it's ok
            // if there is some extra left in the last
            // bucket

            // Show the output like this:
            // It will take 8 buckets to paint the 15' radius circle

            // Bonus: Different colors cover better than
            // others. Let the user pick the color and show
            // the result. The colors are as follows:
            // Red = 100 sq ft/bucket
            // Blue = 120 sq ft/bucket
            // Green = 90 sq ft/bucket
            // Yellow = 70 sq ft/bucket

            // Extra Bonus: The colors also cost different
            // amounts. Tell the user how much it will cost
            // to paint their field.
            // Red = 25$ / bucket
            // Blue = 28$ / bucket
            // Green = 33$ / bucket
            // Yellow = 22$ / bucket

            using System;
            using System.Collections.Generic;
            using System.Linq;
            using System.Text;
            using System.Threading.Tasks;

namespace ConsoleApplication2
    {
        class Program
        {
            static void Main(string[] args)
            {
                string answer;
                Console.WriteLine("What is the radius of your circle (as a whole number)?");
                answer = Console.ReadLine();
                int radius = Convert.ToInt16(answer);

                double area = Math.Pow(radius, 2) * Math.PI;

                int coverage = 1;
                int cost;


                Console.WriteLine("What color are you using? (red, blue, green, yellow)");
                answer = Console.ReadLine();
                answer = answer.ToLower();
                switch (answer)
                {
                    case "red":
                        coverage = 100;
                        cost = 25;
                        break;
                    case "blue":
                        coverage = 120;
                        cost = 28;
                        break;
                    case "green":
                        coverage = 90;
                        cost = 33;
                        break;
                    case "yellow":
                        coverage = 70;
                        cost = 22;
                        break;
                    default:
                        coverage = 100;
                        cost = 25;
                        break;

                }

                Console.WriteLine("It will take " + Math.Ceiling(area / coverage) + " buckets to paint the " + radius + " radius circle. It will cost " + (Math.Ceiling(area / coverage) * cost));
                Console.ReadLine();


            }
        }
    }

}
    }
}
