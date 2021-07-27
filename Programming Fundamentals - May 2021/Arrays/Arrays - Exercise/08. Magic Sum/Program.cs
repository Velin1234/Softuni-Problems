using System;
using System.Linq;

namespace _08._Magic_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();
            int MagicNum = int.Parse(Console.ReadLine());

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {

                    int MagicSum = nums[i] + nums[j];
                    if (MagicSum == MagicNum)
                    {
                        Console.WriteLine($"{nums[i]} {nums[j]}");
                    }
                }
            }

        }
    }
}
