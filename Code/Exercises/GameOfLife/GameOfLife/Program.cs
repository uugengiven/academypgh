using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    class Program
    {
        static void Main(string[] args)
        {
            bool[,] grid = CreateGrid();

            Draw(grid);
            while (true)
            {
                grid = NextGeneration(grid);
                Console.Clear();
                Draw(grid);
                System.Threading.Thread.Sleep(1000);
            }
            Console.ReadLine();

        }

        static bool[,] NextGeneration(bool[,] grid)
        {
            bool[,] newGrid = new bool[40, 40];
            for (int i = 0; i < 40; i++)
            {
                for (int j = 0; j < 40; j++)
                {
                    newGrid[i, j] = grid[i, j];
                    int neighbors = NumNeighbors(i, j, grid);
                    if (grid[i, j])
                    {
                        
                        if (neighbors > 3)
                        {
                            newGrid[i, j] = false;
                        }
                        else if (neighbors > 1)
                        {
                            newGrid[i, j] = true;
                        }
                        else
                        {
                            newGrid[i, j] = false;
                        }
                    }
                    else if (neighbors == 3)
                    {
                        newGrid[i, j] = true;
                    }
                }
            }
            return newGrid;
        }

        static int NumNeighbors(int x, int y, bool[,] grid)
        {
            // figure out the number of neighbors are alive/true
            int neighbors = 0;
            int lowX = 0;
            int lowY = 0;
            int highX = 0;
            int highY = 0;
            if (x > 0)
            {
                lowX = x - 1;
            }
            else
            {
                lowX = x;
            }

            if (x < 39)
            {
                highX = x + 1;
            }
            else
            {
                highX = x;
            }

            if (y > 0)
            {
                lowY = y - 1;
            }
            else
            {
                lowY = y;
            }
            if (y < 39)
            {
                highY = y + 1;
            }
            else
            {
                highY = y;
            }

            for (int i = lowX; i <= highX; i++)
            {
                for (int j = lowY; j <= highY; j++)
                {
                        if (grid[i, j])
                        {
                            neighbors++;
                        }
                }
            }
            if (grid[x,y])
            {
                neighbors--;
            }
            return neighbors;
        }

        static bool[,] CreateGrid()
        {
            bool[,] grid = new bool[40, 40];
            Random rnd = new Random();
            for (int i = 0; i < 40; i++)
            {
                for (int j = 0; j < 40; j++)
                {
                    if (rnd.Next(2) > 0)
                    {
                        grid[i, j] = true;
                    }
                    else
                    {
                        grid[i, j] = false;
                    }
                    
                }
            }
            return grid;
        }

        static void Draw(bool[,] grid)
        {
            for (int i = 0; i < grid.GetLength(0); i++)
            {
                for (int j = 0; j < grid.GetLength(1); j++)
                {
                    if (grid[i,j])
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write("-");
                    }
                }
                Console.Write("\n");
            }
        }
    }
}
