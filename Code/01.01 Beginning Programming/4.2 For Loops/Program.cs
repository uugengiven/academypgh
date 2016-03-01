using System;


namespace ForLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("The value of i is " + i);
            }


            Console.ReadLine();

            int j = 0;
            int numberOfLoops = 100;

            for (; j < numberOfLoops; j++)
            {
                // you can use other variables, you do not have to declare them in the for declaration
                // this will run 100 times, just like the previous one
                // why 100 and not 101 if i starts at 0?
            }
        }
    }
}
