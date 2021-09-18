using System;
using System.Collections.Generic;
using System.Linq;

namespace _5._Print_Even_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            Queue<int> evenNums = new Queue<int>();
            foreach (var num in nums)
            {
                if (num % 2 == 0)
                {
                    evenNums.Enqueue(num);
                }
            }
            Console.WriteLine(string.Join(", ",evenNums));
        }
    }
}
