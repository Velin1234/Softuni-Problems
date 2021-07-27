using System;

using System.Collections.Generic;
using System.Linq;

namespace _03._Moving_Target
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> targets = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            string[] commands = Console.ReadLine().Split(" ");

            while (commands[0] != "End")
            {
                int index = Convert.ToInt32(commands[1]);
                switch (commands[0])
                {
                    case "Shoot":
                        try
                        {
                            int power = Convert.ToInt32(commands[2]);
                            targets[index] -= power;
                            if (targets[index] <= 0)
                            {
                                targets.Remove(targets[index]);
                            }
                        }
                        catch
                        {

                        }
                        break;

                    case "Add":
                        int value = Convert.ToInt32(commands[2]);
                        if (index >= 0 && index < commands.Length)
                        {
                            targets.Insert(index, value);
                        }
                        else
                        {
                            Console.WriteLine("Invalid placement!");
                        }
                        break;

                    case "Strike":
                        try
                        {
                            int radius = Convert.ToInt32(commands[2]);
                            targets.RemoveRange(index - radius, radius * 2 + 1);
                        }
                        catch
                        {
                            Console.WriteLine("Strike missed!");
                        }
                        break;
                }
                commands = Console.ReadLine().Split(" ");
            }

            Console.WriteLine(string.Join("|", targets));
        }
    }
}
