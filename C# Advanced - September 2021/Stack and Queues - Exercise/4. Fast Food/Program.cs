using System;
using System.Collections.Generic;
using System.Linq;

namespace _4._Fast_Food
{
    class Program
    {
        static void Main(string[] args)
        {
            int quanity = int.Parse(Console.ReadLine());
            List<int> orders = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            Queue<int> queueOrders = new Queue<int>();
            foreach (var order in orders)
            {
                queueOrders.Enqueue(order);
            }

            int maxOrder = queueOrders.Max();

            while (queueOrders.Count > 0)
            {
                if (quanity < queueOrders.Peek())
                {
                    break;
                }
                quanity -= queueOrders.Peek();
                queueOrders.Dequeue();

            }
            Console.WriteLine(maxOrder);

            if (queueOrders.Count > 0)
            {
                Console.WriteLine($"Orders left: " + $"{string.Join(" ", queueOrders)}");
            }
            else
            {
                Console.WriteLine("Orders complete");
            }
        }
    }
}
