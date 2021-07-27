using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._List_Manipulation_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine()
                .Split(" ")
                .Select(double.Parse)
                .ToList();

            string[]cmd = Console.ReadLine().Split(" ");
            while (cmd[0] != "end")
            {
                switch (cmd[0])
                {
                    case "Add":
                        numbers.Add(Convert.ToDouble(cmd[1]));
                        break;
                    case "Remove":
                        numbers.Remove(Convert.ToDouble(cmd[1]));
                        break;
                    case "RemoveAt":
                        numbers.RemoveAt(Convert.ToInt32(cmd[1]));
                        break;
                    case "Insert":
                        numbers.Insert(Convert.ToInt32(cmd[2]),Convert.ToDouble(cmd[1]));
                        break;
                }
                cmd = Console.ReadLine().Split(" ");
            }
            Console.WriteLine(string.Join(" ",numbers));
        }
    }
}
