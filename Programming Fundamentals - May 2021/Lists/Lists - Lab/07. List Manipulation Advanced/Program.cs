using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._List_Manipulation_Advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine()
                .Split(" ")
                .Select(double.Parse)
                .ToList();

            int indexChanges = 0;

            string[] cmd = Console.ReadLine().Split(" ");
            while (cmd[0] != "end")
            {
                switch (cmd[0])
                {
                    case "Add":
                        numbers.Add(Convert.ToDouble(cmd[1]));
                        indexChanges++;
                        break;

                    case "Remove":
                        numbers.Remove(Convert.ToDouble(cmd[1]));
                        indexChanges++;
                        break;

                    case "RemoveAt":
                        numbers.RemoveAt(Convert.ToInt32(cmd[1]));
                        indexChanges++;
                        break;

                    case "Insert":
                        numbers.Insert(Convert.ToInt32(cmd[2]), Convert.ToDouble(cmd[1]));
                        indexChanges++;
                        break;

                    case "Contains":
                        if (numbers.Contains(Convert.ToInt32(cmd[1])))
                        {
                            Console.WriteLine("Yes");
                        }
                        else
                        {
                            Console.WriteLine("No such number");
                        }
                        break;

                    case "PrintEven":
                        Console.WriteLine(string.Join(" ", numbers.Where(number => number % 2 == 0)));
                        break;

                    case "PrintOdd":
                        Console.WriteLine(string.Join(" ", numbers.Where(number => number % 2 != 0)));
                        break;

                    case "GetSum":
                        Console.WriteLine(numbers.Sum());
                        break;

                    case "Filter":
                        switch (cmd[1])
                        {
                            case ">":
                                Console.WriteLine(string.Join(" ", numbers.Where(number => number > Convert.ToInt32(cmd[2]))));
                                break;
                            case ">=":
                                Console.WriteLine(string.Join(" ", numbers.Where(number => number >= Convert.ToInt32(cmd[2]))));
                                break;
                            case "<":
                                Console.WriteLine(string.Join(" ", numbers.Where(number => number < Convert.ToInt32(cmd[2]))));
                                break;
                            case "<=":
                                Console.WriteLine(string.Join(" ", numbers.Where(number => number <= Convert.ToInt32(cmd[2]))));
                                break;
                        }
                        break;
                }
                cmd = Console.ReadLine().Split(" ");
            }
            if (indexChanges > 0)
            {
                Console.WriteLine(string.Join(" ",numbers));
            }
        }
    }
}
