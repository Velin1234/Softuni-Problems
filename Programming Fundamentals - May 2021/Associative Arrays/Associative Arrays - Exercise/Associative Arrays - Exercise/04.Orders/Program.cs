using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> orders = new Dictionary<string, double>();
            List<string> order = Console.ReadLine().Split(" ").ToList();
            while (order[0] != "buy")
            {
                string product = order[0];
                double totalPrice = Convert.ToDouble(order[1]) * Convert.ToDouble(order[2]);

                if (orders.ContainsKey(product))
                {
                    orders[product] += totalPrice;
                }
                else
                {
                    orders.Add(product, totalPrice);
                }
                
                order = Console.ReadLine().Split(" ").ToList();
            }

            foreach (var o in orders)
            {
                Console.WriteLine($"{o.Key} -> {o.Value:f2}");
            }
        }
    }
}
