using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
               .Split(" ")
               .Select(int.Parse)
               .ToList();

            string[] cmd = Console.ReadLine().Split(" ");
            while (cmd[0] != "end")
            {
                switch (cmd[0])
                {
                    case "Delete":
                        for (int i = 0; i <= numbers.Count-1; i++)
                        {
                            if (numbers[i]==Convert.ToInt32(cmd[1]))
                            {
                                numbers.Remove(numbers[i]);
                            }
                        }
                        break;

                    case "Insert":
                        numbers.Insert(Convert.ToInt32(cmd[2]), Convert.ToInt32(cmd[1]));
                        break;
                }
                cmd = Console.ReadLine().Split(" ");
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
