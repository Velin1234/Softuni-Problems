using System;

namespace _06.Fishland
{
    class Program
    {
        static void Main(string[] args)
        {
            // скумрия - mackerel ; цаца - sprat ; паламуд - bonito; сафрид - horse mackerel; миди - mussels;

            double price_per_kg_mackerel = double.Parse(Console.ReadLine());
            double price_per_kg_sprat = double.Parse(Console.ReadLine());
            
            double kg_bonito = double.Parse(Console.ReadLine());
            double kg_horse_mackerel = double.Parse(Console.ReadLine());
            double kg_mussles = double.Parse(Console.ReadLine());

            double price_per_kg_bonito = price_per_kg_mackerel + price_per_kg_mackerel * 0.6;
            double price_per_kg_horse_mackerel = price_per_kg_sprat + price_per_kg_sprat * 0.8;
            double price_per_kg_mussles = 7.50;

            double whole_price_bonito = kg_bonito * price_per_kg_bonito;
            double whole_price_horse_mackerel = kg_horse_mackerel * price_per_kg_horse_mackerel;
            double whole_price_mussles = kg_mussles * price_per_kg_mussles;

            double whole_bill = whole_price_bonito + whole_price_horse_mackerel + whole_price_mussles;
            Console.WriteLine($"{whole_bill:f2}");
        }
    }
}
