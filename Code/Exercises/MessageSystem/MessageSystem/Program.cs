using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageSystem
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
             */

            // Version that can increase the array size as needed

            string[] messages = new string[2];

            bool exit = false;
            string response = "";
            string userMessage = "";
            while(!exit)
            {
                Console.WriteLine("Please make a choice \n A) Enter Message \n B) Retrieve Message \n Q) Exit");
                response = Console.ReadLine();
                switch(response.ToLower())
                {
                    case "a":
                        // let the user enter a message
                        Console.WriteLine("Enter your message");
                        userMessage = Console.ReadLine();
                        if(!String.IsNullOrEmpty(messages[messages.Length - 1]))
                        {
                            // the last message is used, increase the array size
                            string[] newMessages = new string[messages.Length + 10]; // increase by 10 each time
                            for (int i = 0; i < messages.Length; i++)
                            {
                                newMessages[i] = messages[i];
                            }
                            messages = newMessages;
                        }
                        for (int i = 0; i < messages.Length; i++)
                        {
                            if(String.IsNullOrEmpty(messages[i]))
                            {
                                // found the first blank
                                messages[i] = userMessage;
                                Console.WriteLine("Your message is stored as ID " + i);
                                break;
                            }
                        }
                        break;
                    case "b":
                        // let the user retrieve a message
                        Console.WriteLine("Please enter the ID you wish to retrieve");
                        userMessage = Console.ReadLine();
                        int id;
                        if(int.TryParse(userMessage, out id))
                        {
                            if(id < messages.Length && !String.IsNullOrEmpty(messages[id]))
                            {
                                Console.WriteLine("Your message is as follows: " + messages[id]);
                            }
                            else
                            {
                                Console.WriteLine("No such ID stored");
                            }
                        }
                        else
                        {
                            Console.WriteLine("I didn't recognize that as a valid ID");
                        }
                        break;
                    case "q":
                    case "exit":
                        exit = true;
                        Console.WriteLine("Exiting - Press Enter to Quit");
                        Console.ReadLine();
                        break;

                }
            }


        }
    }
}
 