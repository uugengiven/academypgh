using System;


namespace If_Then_Else
{
    class Program
    {
        static void Main(string[] args)
        {
            // Basic Conditional

            if (true)
            {
                Console.WriteLine("This is true and you will see it.");
            }

            if (false)
            {
                Console.WriteLine("This block of code will not be executed");
                // the IDE/compiler will also tell you this
            }

            Console.ReadLine();


            // Conditional Operators

            string condition = "a";
            int number = 15;

            if (condition == "a")
            {
                Console.WriteLine("== evaluates if the two sides are equal in value");
            }

            if (5 == 5)
            {
                Console.WriteLine("This works for any value types plus any object types that support the == operator");
            }

            if ((3 + 3) < 10)
            {
                Console.WriteLine("These are normal math operators, < evaluates if the left side is less than the right side");
            }

            //if ("this is" < "less than this")
            //{
            //    Console.WriteLine("It turns out, strings (and some other object types) do not like using operators that don't make sense for them");
            //}

            if (4 * 4 >= 16)
            {
                Console.WriteLine(">= evalutes if the left side is greater than or equal to the right");
            }

            if (8 < number)
            {
                Console.WriteLine("Variables can be on the left or right or both sides of an operator");
            }

            //if (condition == number)
            //{
            //    Console.WriteLine("There are no implicit string conversions in boolean operators");
            //}



            // Conditional Boolean Operators

            if (!false)
            {
                Console.WriteLine("! reverses the boolean value (true to false, false to true)");
            }

            if (true && true)
            {
                Console.WriteLine("&& evaluates that both sides evaluate to true");
            }

            if (false && false)
            {
                Console.WriteLine("&& evaluates that both sides evaluate to true");
            }

            if (false || true)
            {
                Console.WriteLine("|| evaluates that at least one side evaluates to true");
            }

            Console.ReadLine();

            // Combined Conditional Operators

            if(true || (false == false))
            {
                Console.WriteLine("Combined conditionals evaluate each section in order, building to a final true/false value");
            }

            if ((true || false) == false)
            {
                Console.WriteLine("Order of operations is important for these combined conditions");
            }


        }
    }
}
