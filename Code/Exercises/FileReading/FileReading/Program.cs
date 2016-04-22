using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileReading
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = System.IO.File.ReadAllText("./readme.txt");
            Console.WriteLine(text);
            Console.ReadLine();

            // don't forget to make readme.txt copy into the output directory!

            System.IO.StreamReader file = new System.IO.StreamReader("./readme.txt");
            string line;

            // fewer lines way
            while ((line = file.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }

            // more understandable what is happening way
            line = file.ReadLine();
            while (line != null)
            {
                Console.WriteLine(line);
            }

            Console.ReadLine();
        }
    }
}
