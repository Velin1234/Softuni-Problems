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
            Dictionary<string, int> ordersQuanities = new Dictionary<string, int>();
            List<string> order = Console.ReadLine().Split(" ").ToList();
            while (order[0] != "buy")
            {
                string product = order[0];
                double price = Convert.ToDouble(order[1]);
                int quantity = Convert.ToInt32(order[2]);
                
                if (orders.ContainsKey(product) && ordersQuanities.ContainsKey(product))
                {
                    orders[product] = price;
                    ordersQuanities[product] += quantity;
                }
                else
                {
                    orders.Add(product, price);
                    ordersQuanities.Add(product, quantity);
                }

                order = Console.ReadLine().Split(" ").ToList();
            }

            foreach (var or in orders)
            {
                foreach (var orQ in ordersQuanities)
                {
                    if (or.Key == orQ.Key)
                    {
                        double totalPrice = or.Value * orQ.Value;
                        Console.WriteLine($"{or.Key} -> {totalPrice:f2}");
                    }
                }
            }
        }
    }
}
