using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Stack_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> numbers = new Stack<int>();
            int[] inputNums = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int sum = 0;
            foreach (var num in inputNums)
            {
                numbers.Push(num);
            }
            
            List<string> cmd = Console.ReadLine().Split(" ").ToList();
            while (cmd[0].ToLower() != "end")
            {
                switch (cmd[0].ToLower())
                {
                    case "add":
                        numbers.Push(Convert.ToInt32(cmd[1]));
                        numbers.Push(Convert.ToInt32(cmd[2]));
                        break;
                    case "remove":
                        if (numbers.Count >= Convert.ToInt32(cmd[1]))
                        {
                            for (int i = 0; i < Convert.ToInt32(cmd[1]); i++)
                            {
                                numbers.Pop();
                            }
                        }
                        break;
                }
                cmd = Console.ReadLine().Split(" ").ToList();
            }

            foreach (var num in numbers)
            {
                sum += num;
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
