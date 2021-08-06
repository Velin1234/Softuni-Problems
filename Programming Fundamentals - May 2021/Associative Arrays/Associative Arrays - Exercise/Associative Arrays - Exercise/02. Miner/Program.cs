using System;
using System.Collections.Generic;

namespace _02._Miner
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> ores = new Dictionary<string, int>();
            string ore = Console.ReadLine();
            while (ore != "stop")
            {
                int quanity = int.Parse(Console.ReadLine());
                ores.Add(ore, quanity);
                ore = Console.ReadLine();
            }

            foreach (var Ore in ores)
            {
                Console.WriteLine($"{Ore.Key} -> {Ore.Value}");
            }
        }
    }
}
