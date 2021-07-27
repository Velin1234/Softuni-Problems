using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._List_Operations
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

            while(cmd[0] != "End")
            {
                switch (cmd[0])
                {
                    case "Add":
                        numbers.Add(Convert.ToInt32(cmd[1]));
                        break;

                    case "Remove":
                        try
                        {
                            numbers.Remove(numbers[Convert.ToInt32(cmd[1])]);
                        }
                        catch 
                        {
                            Console.WriteLine("Invalid index");
                        }
                        break;

                    case "Insert":
                        try
                        {
                            numbers.Insert(Convert.ToInt32(cmd[2]), Convert.ToInt32(cmd[1]));
                        }
                        catch 
                        {
                            Console.WriteLine("Invalid index");
                        }
                        break;

                    case "Shift":
                        switch (cmd[1])
                        {
                            case "right":
                                try
                                {
                                    ShiftRight(numbers, Convert.ToInt32(cmd[2]));

                                }
                                catch 
                                {
                                    Console.WriteLine("Invalid index");

                                }
                                break;

                            case "left":
                                try
                                {
                                    ShiftLeft(numbers, Convert.ToInt32(cmd[2]));

                                }
                                catch 
                                {
                                    Console.WriteLine("Invalid index");

                                }
                                break;
                        }
                        break;
                }
                cmd = Console.ReadLine().Split(" ");
            }
            Console.WriteLine(string.Join(" ",numbers));
        }

        static void ShiftLeft(List<int> numbers, int count)
        {
            for (int i = 0; i < count; i++)
            {
                numbers.Add(numbers[0]);
                numbers.RemoveAt(0);
            }
        }
        static void ShiftRight(List<int> numbers, int count)
        {

            for (int i = 0; i < count; i++)
            {
                numbers.Insert(0, numbers[numbers.Count - 1]);
                numbers.RemoveAt(numbers.Count - 1);
            }
        }

    }
}
