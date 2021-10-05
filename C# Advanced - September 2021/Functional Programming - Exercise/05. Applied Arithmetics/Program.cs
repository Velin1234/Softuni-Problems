using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Applied_Arithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            string input = Console.ReadLine();
            while (input != "end")
            {
                switch (input)
                {
                    case "add":
                        for (int i = 0; i < nums.Count; i++)
                        {
                            nums[i]++;
                        }
                        break;
                    case "multiply":
                        for (int i = 0; i < nums.Count; i++)
                        {
                            nums[i] *= 2;
                        }
                        break;
                    case "subtract":
                        for (int i = 0; i < nums.Count; i++)
                        {
                            nums[i]--;
                        }
                        break;
                    case "print":
                        Console.WriteLine(string.Join(" ", nums));
                        break;
                }
                input = Console.ReadLine();
            }
        }
    }
}
