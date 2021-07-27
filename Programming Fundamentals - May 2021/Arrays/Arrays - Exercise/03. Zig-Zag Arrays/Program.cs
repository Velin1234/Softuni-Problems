using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Zig_Zag_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<int> Zig = new List<int>();
            List<int> Zag = new List<int>();
            for (int i = 0; i < n; i++)
            {
                if (i % 2 == 0)
                {
                    int[] nums = Console.ReadLine()
                        .Split(" ")
                        .Select(int.Parse)
                        .ToArray();
                    Zig.Add(nums[0]);
                    Zag.Add(nums[1]);
                }
                else
                {
                    int[] nums = Console.ReadLine()
                        .Split(" ")
                        .Select(int.Parse)
                        .ToArray();
                    Zag.Add(nums[0]);
                    Zig.Add(nums[1]);
                }
            }
            Console.WriteLine(string.Join(" ", Zig));
            Console.WriteLine(string.Join(" ", Zag));

        }
    }
}
