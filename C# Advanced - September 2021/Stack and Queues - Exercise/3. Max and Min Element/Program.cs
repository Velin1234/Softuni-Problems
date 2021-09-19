using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._Max_and_Min_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Stack<int> nums = new Stack<int>();
            for (int i = 0; i < n; i++)
            {
                List<int> input = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
                switch (input[0])
                {
                    case 1:
                        nums.Push(input[1]);
                        break;
                    case 2:
                        if (nums.Count >0)
                        {
                            nums.Pop();
                        }
                        break;
                    case 3:
                        if (nums.Count > 0)
                        {
                            Console.WriteLine(nums.Max());
                        }
                        break;
                    case 4:
                        if (nums.Count > 0)
                        {
                            Console.WriteLine(nums.Min());
                        }
                        break;
                }
            }
            Console.WriteLine(string.Join(", ",nums));

        }
    }
}
