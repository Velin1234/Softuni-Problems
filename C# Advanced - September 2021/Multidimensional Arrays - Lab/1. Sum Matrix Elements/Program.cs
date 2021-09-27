using System;
using System.Linq;

namespace _1._Sum_Matrix_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] matrixSize = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int sum = 0;
            for (int i = 0; i < matrixSize[0]; i++)
            {
                int[]elements = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
                sum += elements.Sum();
            }
            Console.WriteLine(matrixSize[0]);
            Console.WriteLine(matrixSize[1]);
            Console.WriteLine(sum);
        }
    }
}
