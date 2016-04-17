using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageSystemFunctions
{
    public class Program
    {
        static string[] messages;

        static void Main(string[] args)
        {
            string choice;
            string message;
            int id;
            bool quit = false;

            Init();

            while (!quit)
            {
                Console.WriteLine("Please make a choice:\n A) Store a message\n B) Retrieve a message\n Q) Exit");
                choice = Console.ReadLine();

                switch (choice.ToLower())
                {
                    case "a":
                        Console.WriteLine("Enter your message: ");
                        message = Console.ReadLine();
                        Console.WriteLine("Your ID is: " + InsertMessage(message));
                        break;
                    case "b":
                        Console.WriteLine("Enter the ID you wish to retrieve: ");
                        message = Console.ReadLine();
                        if (int.TryParse(message, out id))
                        {
                            Console.WriteLine("Your Message Is: " + RetriveMessage(id));
                        }
                        Console.WriteLine("You did not enter a number");
                        break;
                    case "q":
                    case "exit":
                        quit = true;
                        Console.WriteLine("Quitting... press enter to close window");
                        Console.ReadLine();
                        break;
                }
            }
        }

        static void Init()
        {
            // intialize everything to default values
            messages = new string[10];
        }

        static void IncreaseMessageStore()
        {
            // increase the size of the messages array
            string[] newMessages = new string[messages.Length + 10];
            for (int i = 0; i < messages.Length; i++)
            {
                newMessages[i] = messages[i];
            }
            messages = newMessages;
        }

        static int InsertMessage(string message)
        {
            if (!string.IsNullOrEmpty(messages[messages.Length - 1]))
            {
                IncreaseMessageStore();
            }
            for (int i = 0; i < messages.Length - 1; i++)
            {
                if (String.IsNullOrEmpty(messages[i]))
                {
                    messages[i] = message;
                    return i;
                }
            }
            return -1; // if this line is hit, something went wrong, return an impossible ID
        }

        static string RetriveMessage(int ID)
        {
            if (ID < messages.Length && ID >= 0)
            {
                if (string.IsNullOrEmpty(messages[ID]))
                {
                    return "No Message Found";
                }
                else
                {
                    return messages[ID];
                }
            }
            return "ID Out of Range (either too high or negative)";
        }
    }
}
