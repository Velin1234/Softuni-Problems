using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Memory_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> elements = Console.ReadLine().Split(" ").ToList();
            string[] inputs = Console.ReadLine().Split(" ");
            int turns = 0;
            while (inputs[0]!= "end")
            {
                turns++;
                if (Convert.ToInt32(inputs[0]) < 0 || Convert.ToInt32(inputs[1]) < 0)
                {
                    int middle = elements.Count / 2;
                    elements.Insert(middle, $"-{turns}a");
                    elements.Insert(middle, $"-{turns}a");
                    Console.WriteLine("");
                }
                else if (elements[Convert.ToInt32(inputs[0])] == elements[Convert.ToInt32(inputs[1])])
                {
                    string element = elements[Convert.ToInt32(inputs[0])];
                    for (int i = 0; i < elements.Count; i++)
                    {
                        if (elements[i] == element)
                        {
                            elements.Remove(elements[i]);
                        }
                    }
                    Console.WriteLine($"Congrats! You have found matching elements - {element}!");
                    if (elements.Count == 1)
                    {
                        Console.WriteLine($"Congrats! You have found matching elements - {element}!");
                        elements.Clear();
                    }
                }
                else
                {
                    Console.WriteLine("Try again!");
                }
                inputs = Console.ReadLine().Split(" ");
            }
            if (elements.Count != 0)
            {
                Console.WriteLine("Sorry you lose :( ");
            }
            else
            {
                Console.WriteLine($"You have won in {turns} turns!");
            }
            Console.WriteLine(string.Join(" ",elements));
        }
    }
}
