using System;

namespace _10.Odd_Even_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());
            int oddSum = 0;
            int evenSum = 0;
            
            for (int i = 0; i < numbers; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (i % 2 == 0 && i < numbers)
                {
                    oddSum += number;
                }
                else
                {
                    evenSum += number;
                }
            }

            if (oddSum == evenSum)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {evenSum}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(oddSum-evenSum)}");
            }
        }
    }
}
