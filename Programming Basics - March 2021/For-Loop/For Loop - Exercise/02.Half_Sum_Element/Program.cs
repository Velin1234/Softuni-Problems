using System;

namespace _02.Half_Sum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int max = int.MinValue;
            int number = int.Parse(Console.ReadLine());
            for (int i = 0; i < number; i++)
            {
                int numbers = int.Parse(Console.ReadLine());
                sum += numbers;

                if (numbers > max)
                {
                    max = numbers;
                }
            }
            int sumWithoutMaxNum = sum - max;
            if (max == sumWithoutMaxNum) 
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {max}");
            }
            else
            {
                int diff = Math.Abs(max - sumWithoutMaxNum);
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {diff}");
            }
        }
    }
}
