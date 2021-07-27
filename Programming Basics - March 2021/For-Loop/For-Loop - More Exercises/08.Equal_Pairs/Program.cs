﻿using System;

namespace _08.Equal_Pairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int maxdiff = 0;
            int prevSum = 0;


            for (int i = 0; i < n; i++)
            {
                int i1 = int.Parse(Console.ReadLine());
                int i2 = int.Parse(Console.ReadLine());
                int sum = i1 + i2;
                if (i == 0)
                {
                    prevSum = sum;
                }
                int diff = Math.Abs(prevSum - sum);
                if (diff > maxdiff)
                {
                    maxdiff = diff;
                }
                prevSum = sum;
            }

            if (maxdiff == 0)
            {
                Console.WriteLine($"Yes, value={prevSum}");
            }
            else
            {
                Console.WriteLine($"No, maxdiff={maxdiff}");
            }
        }
    }
}
