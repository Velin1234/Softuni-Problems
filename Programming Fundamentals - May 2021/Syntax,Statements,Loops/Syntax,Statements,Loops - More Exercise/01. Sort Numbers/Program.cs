using System;
using System.Collections.Generic;

namespace _01._Sort_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = new List<int>();
            for (int i = 1; i <= 3; i++)
            {
                int num = int.Parse(Console.ReadLine());
                nums.Add(num);
                nums.Sort();
            }
            for (int i = nums.Count - 1; i >= 0; i--)
            {
                Console.WriteLine(string.Join(" ", nums[i]));
            }
        }
    }
}
