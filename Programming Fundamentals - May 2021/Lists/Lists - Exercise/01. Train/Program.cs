using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Train
{
    class Program
    {
        static void Main(string[] args)
        {
            //90/100
            List<int> wagons = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToList();

            int maxCapacity = int.Parse(Console.ReadLine());
            string[] cmd = Console.ReadLine().Split(" ");

            while (cmd[0] != "end")
            {
                if (cmd[0] == "Add")
                {
                    wagons.Add(Convert.ToInt32(cmd[1]));
                }
                else
                {
                    for (int i = 0; i < wagons.Count - 1; i++)
                    {
                        if (wagons[i] + Convert.ToInt32(cmd[0]) <= maxCapacity)
                        {
                            wagons[i] = wagons[i] + Convert.ToInt32(cmd[0]);
                            break;
                        }
                    }
                }

                cmd = Console.ReadLine().Split(" ");
            }
            Console.WriteLine(string.Join(" ",wagons));
        }
    }
}
