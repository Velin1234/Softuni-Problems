using System;

namespace _03.Harvest
{
    class Program
    {
        static void Main(string[] args)
        {
            double square_meters = double.Parse(Console.ReadLine());
            double kg_grape_per_sq_m = double.Parse(Console.ReadLine());
            double liters_wine_for_sale = double.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());

            double kg_grape = square_meters * kg_grape_per_sq_m;
            double liter_wine = 0.4 * kg_grape / 2.5;
            
            if (liter_wine >= liters_wine_for_sale)
            {
                double left_wine = Math.Abs (liter_wine - liters_wine_for_sale);
                double liter_per_worker = left_wine / workers;
                Console.WriteLine($"Good harvest this year! Total wine: {Math.Floor(liter_wine)} liters.");
                Console.WriteLine($"{Math.Ceiling(left_wine)} liters left -> {Math.Ceiling(liter_per_worker)} liters per person.");
            }
            else if (liter_wine < liters_wine_for_sale)
            {
                double needed_liters = liters_wine_for_sale - liter_wine;
                Console.WriteLine($"It will be a tough winter! More {Math.Floor(needed_liters)} liters wine needed."); 
            }            
        }
    }
}
