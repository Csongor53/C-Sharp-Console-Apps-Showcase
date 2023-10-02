using System;
using System.IO;
using System.Threading;

namespace final_proj_flood_fill_cc211049_Janosi
{
    internal class Program
    {
        static int rows;
        static int cols;
        static void Main(string[] args)
        {
            Console.Clear();
            // Read input data from file
            string[] inputLines = File.ReadAllLines("input.txt");

            // Parse input to 2D char array
            rows = inputLines.Length;
            cols = inputLines[0].Length;
            char[,] grid = new char[rows, cols];
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    grid[row, col] = inputLines[row][col];
                }
            }

            // Display the initial state of the grid
            WriteGrid(grid);
            // Add a small delay for visibility
            Thread.Sleep(1000);

            // Find the starting point for the flood fill
            int startX = 0, startY = 0;
            for (int i = 1; i < rows - 1; i++)
            {
                for (int j = 1; j < cols - 1; j++)
                {
                    if (grid[i, j] == 's')
                    {
                        startX = i;
                        startY = j;
                        break;
                    }
                }
            }

            // Perform the flood fill
            FloodFill(grid, startX, startY);

            // Write output data to file
            string output = "";
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    output += grid[i, j];
                }
                output += "\n";
            }
            File.WriteAllText("output.txt", output);
        }

        static void FloodFill(char[,] grid, int x, int y)
        {
            if ((x < 0) || (x >= rows)) return;
            if ((y < 0) || (y >= cols)) return;
            if (grid[x, y] == ' ' || grid[x, y] == 's')
            {
                // Mark the current cell as filled
                grid[x, y] = 'x';

                // Write the current state of the grid to the console
                WriteGrid(grid);

                // Recursively fill the adjacent cells
                FloodFill(grid, x - 1, y);
                FloodFill(grid, x + 1, y);
                FloodFill(grid, x, y - 1);
                FloodFill(grid, x, y + 1);
            }
        }

        static void WriteGrid(char[,] grid)
        {
            // Move the cursor to the top-left corner of the console
            Console.SetCursorPosition(0, 0);

            // Write the current state of the grid
            for (int i = 0; i < grid.GetLength(0); i++)
            {
                for (int j = 0; j < grid.GetLength(1); j++)
                {
                    Console.Write(grid[i, j]);
                }
                Console.WriteLine();
            }

            // Add a small delay for visibility
            Thread.Sleep(1000);
        }
    }
}
