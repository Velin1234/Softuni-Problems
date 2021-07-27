using System;

namespace _01._Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal foodMonth = decimal.Parse(Console.ReadLine());
            decimal hayMonth = decimal.Parse(Console.ReadLine());
            decimal coverMonth = decimal.Parse(Console.ReadLine());
            decimal weight = decimal.Parse(Console.ReadLine());

            for (int day = 1; day <= 30; day++)
            {
                foodMonth -= 0.3M;
                
                if (day % 2 == 0)
                {
                    hayMonth -= foodMonth * 0.05M;
                }

                if (day % 3 == 0)
                {
                    coverMonth -= weight / 3;
                }

                if (foodMonth <= 0 || hayMonth <= 0 || coverMonth <= 0)
                {
                    Console.WriteLine("Merry must go to the pet store!");
                    break;
                }
            }

            if (foodMonth > 0 && hayMonth > 0 && coverMonth > 0)
            {
                Console.WriteLine($"Everything is fine! Puppy is happy! Food: {foodMonth:f2}, Hay: {hayMonth:f2}, Cover: {coverMonth:f2}.");
            }
        }
    }
}
