using System;

namespace _03.Flowers
{
    class Program
    {
        static void Main(string[] args)
        {
            const double summer_spring_price_chrysanthemums = 2.00;
            const double summer_spring_price_roses = 4.10;
            const double  summer_spring_price_tulips = 2.50;

            const double autumn_winter_price_chrysanthemums = 3.75;
            const double autumn_winter_price_roses = 4.50;
            const double autumn_winter_price_tulips = 4.15;

            int bought_chrysanthemum = int.Parse(Console.ReadLine());
            int bought_roses = int.Parse(Console.ReadLine());
            int bought_tulips = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string holiday = Console.ReadLine();

            double total_price_flowers = 0;
            int all_flowers = bought_chrysanthemum + bought_roses + bought_tulips;

            switch (season)
            {
                case "Summer":
                case "Spring":
                    total_price_flowers = bought_chrysanthemum * summer_spring_price_chrysanthemums + bought_roses * summer_spring_price_roses + bought_tulips * summer_spring_price_tulips;
                    if (bought_tulips >= 7)
                    {
                        total_price_flowers -= total_price_flowers * 0.05;
                    }
                    break;
                
                case "Autumn":
                    total_price_flowers = bought_chrysanthemum * autumn_winter_price_chrysanthemums + bought_roses * autumn_winter_price_roses + bought_tulips * autumn_winter_price_tulips;
                    break;

                case "Winter":
                    total_price_flowers = bought_chrysanthemum * autumn_winter_price_chrysanthemums + bought_roses * autumn_winter_price_roses + bought_tulips * autumn_winter_price_tulips;
                    if (bought_roses >= 10)
                    {
                        total_price_flowers -= total_price_flowers * 0.1;
                    }

                    break;
                
                default:
                    break;
            }
            
            if (all_flowers>=20)
            {
                total_price_flowers -= total_price_flowers * 0.2;
            }

            if (holiday =="Y")
            {
                total_price_flowers += total_price_flowers * 0.15;
            }
            
            double price_with_arangement = total_price_flowers + 2;
            Console.WriteLine($"{price_with_arangement:f2}");
        }
    }
}
