using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Top_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] nums = Console.ReadLine()
                .Split(" ")
                .Select(long.Parse)
                .ToArray();

            for (long i = 0; i < nums.Length; i++)
            {
                bool isItBigger = true;
                for (long j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] <= nums[j])
                    {
                        isItBigger = false;
                    }
                }

                if (isItBigger)
                {
                    Console.Write(nums[i] + " ");
                }
            }
        }
    }
}
