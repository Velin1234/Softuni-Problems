using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> genresList = Console.ReadLine().Split(" | ").ToList();
            string[] commands = Console.ReadLine().Split(" ");
            while (commands[0]!= "Stop!")
            {
                switch (commands[0])
                {
                    case "Join":
                        if (!genresList.Contains(commands[1]))
                        {
                            genresList.Add(commands[1]);
                        }
                        break;

                    case "Drop":
                        if (genresList.Contains(commands[1]))
                        {
                            genresList.Remove(commands[1]);
                        }
                        break;

                    case "Replace":
                        if (genresList.Contains(commands[1]) && !genresList.Contains(commands[2]))
                        {
                            int indexOfOld = genresList.IndexOf(commands[1]);
                            genresList.Insert(indexOfOld, commands[2]);
                            genresList.Remove(commands[1]);
                        }
                        break;
                }


                commands = Console.ReadLine().Split(" ");
            }

            Console.WriteLine(string.Join(" ",genresList));
        }
    }
}
