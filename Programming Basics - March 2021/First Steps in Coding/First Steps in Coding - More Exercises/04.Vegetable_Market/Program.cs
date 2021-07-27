using System;

namespace _04.Vegetable_Market
{
    class Program
    {
        static void Main(string[] args)
        {
            double price_per_kg_veg = double.Parse(Console.ReadLine());
            double price_per_kg_fru = double.Parse(Console.ReadLine());
            double kg_veg = double.Parse(Console.ReadLine());
            double kg_fru = double.Parse(Console.ReadLine());
            double whole_price_bgn = (price_per_kg_fru * kg_fru) + (price_per_kg_veg * kg_veg);
            double whole_price_eur = whole_price_bgn / 1.94;
            Console.WriteLine($"{whole_price_eur:f2}");
        }
    }
}
