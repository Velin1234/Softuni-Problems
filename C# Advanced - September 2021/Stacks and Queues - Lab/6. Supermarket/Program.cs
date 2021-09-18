using System;
using System.Collections.Generic;

namespace _6._Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> customers = new Queue<string>();
            string cmd = Console.ReadLine();

            while (cmd != "End")
            {
                if (cmd == "Paid")
                {
                    Console.WriteLine(string.Join("\n", customers));
                    customers.Clear();
                }
                else
                {
                    customers.Enqueue(cmd);
                }
                cmd = Console.ReadLine();
            }
            Console.WriteLine($"{customers.Count} people remaining.");

        }
    }
}
