using System;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship
{
    class Program
    {

        /// <summary>
        /// getInt()
        /// grabs a non negative integer from the User through the Console
        /// </summary>
        /// <param name="prompt">Takes a String to display to User before readline</param>
        /// <returns>non Negative integer</returns>
        static int GetInt(string prompt)
        {
            int result = -1;
            string response = "";
            do
            {
                Console.Write(prompt);
                response = Console.ReadLine();

            } while (!int.TryParse(response, out result));
            return result;
        }

        static bool[,] GetGrid(int totalShips)
        {
            Random rnd = new Random();
            bool[,] setupGrid = new bool[8, 8];
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    setupGrid[i, j] = false;
                }
            }

            for (int x = 0; x < totalShips; x++) //paint battleships
            {
    
                int shipLngth = rnd.Next(6) + 1;
                int dir = rnd.Next(2);
                int xStart = rnd.Next(8);
                int yStart = rnd.Next(8);
                Console.WriteLine("sl" + shipLngth + " dir" + dir + " x" + xStart + " y" + yStart);
                switch (dir) //paint ships
                {
                    case 0: //means we're going down
                        if ((yStart + shipLngth) > 7)
                        {
                            Console.WriteLine("breaky");
                            x--;
                            break;
                        }
                        for (int i = yStart; i < yStart + shipLngth; i++)//check for collision
                        {
                            if (setupGrid[i, yStart]) break;
                        }

                        for (int i = yStart; i < yStart + shipLngth; i++)//put ship in array
                        {
                            setupGrid[i, yStart] = true;
                        }

                        break;
                    case 1: //means we're going down
                        if ((xStart + shipLngth) > 7)
                        {
                            Console.WriteLine("breakx");
                            x--;
                            break;
                        }
                        for (int i = xStart; i < xStart + shipLngth; i++)//check for collision
                        {
                            if (setupGrid[yStart, i]) break;
                        }
                        for (int i = xStart; i < xStart + shipLngth; i++)//put ship in array
                        {
                            setupGrid[xStart, i] = true;
                        }
                        break;


                }
            }

            return setupGrid;
        }

        static bool[,] GetGridFile(int totalShips)
        {
            Random rnd = new Random();
            bool[,] setupGrid = new bool[8, 8];
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    setupGrid[i, j] = false;
                }
            }

            // Read file to set up grid
            System.IO.StreamReader file = new System.IO.StreamReader("./spis.txt");
            string line;

            int x = 0;
            while ((line = file.ReadLine()) != null)
            {
                // fill in one line of the grid
                char[] characters = line.ToCharArray();

                for (int y = 0; y < 8; y++)
                {
                    if (characters[y] == '0')
                    {
                        setupGrid[x, y] = false;
                    }
                    else
                    {
                        setupGrid[x, y] = true;
                    }
                    // setupGrid[x, y] = true / false;
                }
                x++;
            }


            return setupGrid;
        }

        static void Main(string[] args)
        {

            //Create a grid(an array with two dimensions) that is 8 by 8.

            //This grid will hold whether there is a ship in a given square or not.You can use a bool or an int for this.You will need to be able to display this grid, with
            //00000000
            //0000*000
            //00**0000
            //00000000
            //000**000
            //*0*00000
            //00000**0
            //00****00


            //Let the user try to "shoot" a ship by selecting two coordinates (the column and the row)

            //When users shoot an enemy, clear the ship in that cell

            //When all enemies are gone, make the "game" end.

            // Bonus:

            // If user picks a cell next to a ship, say "close!"

            
            bool[,] battleship = new bool[8, 8];
            int[,] screen = new int[8, 8];
            const int totalShips = 4;
            int shipCnt = 0;
            int hits = 0;


            for (int x = 0; x < 8; x++)
            {
                for (int y = 0; y < 8; y++)

                {
                    battleship[x, y] = false;
                    screen[x, y] = 0;
                }
            }

            
            battleship = GetGridFile(totalShips);


            //Making a game loop after "lose"
            bool keepgoing = true;
            while (keepgoing)
            {
                keepgoing = true;

                for (int x = 0; x < 8; x++)
                {
                    Console.WriteLine();
                    for (int y = 0; y < 8; y++)

                    {
                        if (battleship[x, y] == true)
                        {
                            Console.Write("x");
                        }
                        else
                        {
                            Console.Write("o");
                        }

                    }
                }
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("  0 1 2 3 4 5 6 7");
                for (int x = 0; x < 8; x++)
                {
                    Console.WriteLine();
                    Console.Write(x + " ");

                    for (int y = 0; y < 8; y++)

                    {

                        switch (screen[x, y])
                        {
                            case 0:
                                Console.Write("^ ");//water
                                break;
                            case 1:
                                Console.Write("X ");//hit
                                break;
                            case 2:
                                Console.Write("O ");
                                break;
                        };
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("\n");
                int xSpace = GetInt("Enter Y Coordinate:");
                while ((xSpace < 0) || (xSpace >= 8))
                {

                    xSpace = GetInt("Out of range. Enter a number between 0-7. Try again!");

                }

                int ySpace = GetInt("Please type a 'X' coordinate.");

                while (((ySpace < 0) || (ySpace >= 8)))
                {
                    ySpace = GetInt("Out of range. Enter a number between 0-7. Try again!");
                }

                if (battleship[xSpace, ySpace] == true)
                {
                    Console.WriteLine("you hit my battleship, you win!!");
                    battleship[xSpace, ySpace] = false;
                    screen[xSpace, ySpace] = 1;
                    if (++hits == shipCnt) keepgoing = false;

                }
                else
                {
                    Console.WriteLine("you missed!");
                    screen[xSpace, ySpace] = 2;
                }
                Console.WriteLine("Do you want to keep going? \n[y]es\n[n]o");
                string answer = Console.ReadLine();
                switch (answer.ToLower())
                {
                    case "y":
                        Console.WriteLine("Thanks, and here we go!");
                        break;
                    case "n":
                        Console.WriteLine("Thanks for playing!");
                        keepgoing = false;
                        break;
                }
            }

            Console.ReadLine();









        }
    }
}


