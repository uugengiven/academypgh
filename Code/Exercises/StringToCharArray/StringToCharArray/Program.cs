using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringToCharArray
{
    class Program
    {
        static void Main(string[] args)
        {

            /* This program allows users to enter either a message or request a message via ID
             * Users should be given a prompt to chose to enter or retrieve a message
             * If users enter a message, the ID of that message should be returned
             * If an ID is entered under retrieve, the message should be displayed
             * 
             * Please encrypt all messages when they are stored.
             * When the user requests a message, you must decrypt it
             * when showing it to them.
             */

            /*
             * 
             * What would you like to do?
             * a) enter message
             * b) retrieve message
             * q) quit
             * a
             * Enter your message
             * This is my message
             * Your ID is 0
             * What would you like to do?
             * a) enter message
             * b) retrieve message
             * q) quit
             * b
             * Enter your ID
             * 0
             * Your message is: This is my message
             * 
             */
            string someString = "1";
            char someChar = '1';

            string aLongString = "Extra long string";
            char[] aCharArray;

            aCharArray = aLongString.ToCharArray();

            for (int i = 0; i < aCharArray.Length; i++)
            {
                Console.WriteLine("Character: " + aCharArray[i]);
                Console.WriteLine("Value: " + (int)aCharArray[i]);
            }

            Console.WriteLine((char)110);

            Console.ReadLine();
        }
    }
}
