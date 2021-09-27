using System;
using System.Linq;

namespace _2._Sum_Matrix_Columns
{
    class Program
    {
        static void Main(string[] args)
        {
            string[]firstLine = Console.ReadLine().Split(", ").ToArray();
            int rows = int.Parse(firstLine[0]);
            int cols = int.Parse(firstLine[1]);
            int[,] nums = new int[rows, cols];
            for (int row = 0; row < rows; row++)
            {
                string[] lineParts = Console.ReadLine().Split(" ").ToArray();
                for (int col = 0; col < cols; col++)
                {
                    nums[row, col] = int.Parse(lineParts[col]);
                }
            }

            for (int col = 0; col < nums.GetLength(1); col++)
            {
                int colSum = 0;
                for (int row = 0; row < nums.GetLength(0); row++)
                {
                    colSum += nums[row, col];
                }
                Console.WriteLine(colSum);
            }
        }
    }
}
