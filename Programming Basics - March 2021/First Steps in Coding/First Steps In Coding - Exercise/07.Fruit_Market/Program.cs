using System;

namespace _07.Fruit_Market
{
    class Program
    {
        static void Main(string[] args)
        {
            double price_strawberries = double.Parse(Console.ReadLine());
            double amount_bananas = double.Parse(Console.ReadLine());
            double amount_oranges = double.Parse(Console.ReadLine());
            double amount_rasberries = double.Parse(Console.ReadLine());
            double amount_strawberies = double.Parse(Console.ReadLine());
            
            double price_rasberries = price_strawberries / 2;
            double price_oranges = price_rasberries - (price_rasberries * 0.4);
            double price_bananas = price_rasberries - (price_rasberries * 0.8);

            double strawberries = amount_strawberies * price_strawberries;
            double rasberries = amount_rasberries * price_rasberries;
            double oranges = amount_oranges * price_oranges;
            double bananas = amount_bananas * price_bananas;

            double needed_amount_money = strawberries + rasberries + oranges + bananas;
            Console.WriteLine($"{needed_amount_money}");
        }
    }
}
