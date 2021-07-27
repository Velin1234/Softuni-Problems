using System;

namespace _06.Godzilla_vs_Kong
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int statists = int.Parse(Console.ReadLine());
            double price_dressing_statist = double.Parse(Console.ReadLine());
            
            double decor = budget * 0.1;
            double all_statists_dressed = statists * price_dressing_statist;

            if (statists >= 150)
            {
                all_statists_dressed = all_statists_dressed - all_statists_dressed * 0.1;
                double full_price = decor + all_statists_dressed;
                if (full_price > budget)
                {
                    double needed_money = full_price - budget; 
                    Console.WriteLine("Not enough money!");
                    Console.WriteLine($"Wingard needs {needed_money:f2} leva more.");
                }
                else
                {
                    double left_money = budget - full_price;
                    Console.WriteLine("Action!");
                    Console.WriteLine($"Wingard starts filming with {left_money:f2} leva left.");
                }
            }
            else
            {
                
                double full_price = decor + all_statists_dressed;
                if (full_price > budget)
                {
                    double needed_money = full_price - budget;
                    Console.WriteLine("Not enough money!");
                    Console.WriteLine($"Wingard needs {needed_money:f2} leva more.");
                }
                else
                {
                    double left_money = budget - full_price;
                    Console.WriteLine("Action!");
                    Console.WriteLine($"Wingard starts filming with {left_money:f2} leva left.");
                }
            }
        }
    }
}
