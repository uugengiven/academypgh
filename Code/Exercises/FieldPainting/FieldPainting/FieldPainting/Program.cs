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

            // Get the radius and convert to area (sq ft)
            Console.WriteLine("What is the size of your circle (radius in feet)");
            int radius = Convert.ToInt32(Console.ReadLine());
            double area = Math.PI * radius * radius;
            Console.WriteLine("Your area is: " + area);

            // Ask for the color
            Console.WriteLine("What color do you want to paint the circle? red, blue, yellow, green");
            string answer = Console.ReadLine();

            int coverage = 100;

            switch(answer)
            {
                case "red":
                    coverage = 100;
                    break;
                case "blue":
                    coverage = 120;
                    break;
                case "yellow":
                    coverage = 70;
                    break;
                case "green":
                    coverage = 90;
                    break;
                default:
                    coverage = 1;
                    break;
            }

            if (answer == "red")
            {
                coverage = 100;
            }
            else if (answer == "blue")
            {
                coverage = 120;
            }
            else if (answer == "yellow")
            {
                coverage = 70;

            }
            else if (answer == "green")
            {
                coverage = 90;

            }
            else
            {
                coverage = 1;

            }


            // Figure out number of buckets
            double buckets = area / coverage;

            // Print results
            Console.WriteLine("Shopping list: " + Math.Ceiling(buckets) + " buckets - " + answer);

            Console.ReadLine();


        }
    }
}

