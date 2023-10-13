using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pascal_triangle2
{
    internal class UniquePascalTriangle
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Pascal's Triangle Printer!");
            Console.Write("Please enter the number of rows: ");

            if (int.TryParse(Console.ReadLine(), out int numRows) && numRows > 0)
            {
                PrintPascalsTriangle(numRows);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a positive integer for the number of rows.");
            }
            
            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
        }

        static void PrintPascalsTriangle(int numRows)
        {
            Console.WriteLine("\nPascal's Triangle with " + numRows + " rows:\n");

            for (int row = 0; row < numRows; row++)
            {
                int number = 1;
                Console.Write(new string(' ', (numRows - row) * 3));

                for (int col = 0; col <= row; col++)
                {
                    Console.Write(number.ToString().PadLeft(6));
                    number = number * (row - col) / (col + 1);
                }

                Console.WriteLine();
            }
        }
    }
}
