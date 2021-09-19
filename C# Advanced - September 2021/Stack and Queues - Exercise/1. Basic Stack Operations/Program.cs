using System;
using System.Collections.Generic;
using System.Linq;

namespace _1._Basic_Stack_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> nums = new Stack<int>();
            List<int> input = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

            int N = input[0];
            int S = input[1];
            int X = input[2];
            List<int> nNums = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            foreach (var num in nNums)
            {
                nums.Push(num);
            }

            for (int i = 0; i < S; i++)
            {
                nums.Pop();
            }

            if (nums.Contains(X))
            {
                Console.WriteLine("true");
            }
            else
            {
                if (nums.Count > 0)
                {
                    Console.WriteLine(nums.Min());
                }
                else
                {
                    Console.WriteLine(0);
                }
            }
        }
    }
}
