using System;
using System.Linq;

namespace _06._Equal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();
            int sumLeft = 0;
            int sumRight = 0;

            for (int i = 0; i <= numbers.Length - 1; i++)
            {
                if (numbers.Length == 1)
                {
                    Console.WriteLine(0);
                    return;
                }
                sumLeft = 0;
                for (int iLeft = i; iLeft > 0; iLeft--)
                {
                    int nextPosition = iLeft - 1;
                    if (iLeft > 0)
                    {
                        sumLeft += numbers[nextPosition];
                    }
                }

                sumRight = 0;
                for (int iRight = i; iRight < numbers.Length; iRight++)
                {
                    int nextPosition = (iRight + 1);
                    if (iRight < numbers.Length - 1)
                    {
                        sumRight += numbers[nextPosition];
                    }
                }

                if (sumLeft == sumRight)
                {
                    Console.WriteLine(i);
                    return;
                }

            }
            Console.WriteLine("no");
        }
    }
}
