using System;

namespace _02.Bike_Race
{
    class Program
    {
        static void Main(string[] args)
        {
            const double junior_trail_price = 5.50;
            const double junior_cross_country_price = 8;
            const double junior_downhill_price = 12.25;
            const double junior_road_price = 20;

            const double senior_trail_price = 7;
            const double senior_cross_country_price = 9.50;
            const double senior_downhill_price = 13.75;
            const double senior_road_price = 21.50;

            int number_of_junior_cyclist = int.Parse(Console.ReadLine());
            int number_of_senior_cyclist = int.Parse(Console.ReadLine());
            string trace = Console.ReadLine();

            double budget = 0;

            switch (trace)
            {
                case "trail":
                    budget = (number_of_junior_cyclist * junior_trail_price + number_of_senior_cyclist * senior_trail_price);
                    budget -= budget * 0.05;
                    break;

                case "cross-country":
                    budget = (number_of_junior_cyclist * junior_cross_country_price + number_of_senior_cyclist * senior_cross_country_price);
                    budget -= budget * 0.05;
                    if (number_of_junior_cyclist + number_of_senior_cyclist >= 50)
                    {
                        budget -= budget * 0.25;
                    }
                    break;

                case "downhill":
                    budget = (number_of_junior_cyclist * junior_downhill_price + number_of_senior_cyclist * senior_downhill_price);
                    budget -= budget * 0.05;
                    break;

                case "road":
                    budget = (number_of_junior_cyclist * junior_road_price + number_of_senior_cyclist * senior_road_price);
                    budget -= budget * 0.05;
                    break;

                default:
                    break;
            }
            Console.WriteLine($"{budget:f2}");
        }
    }
}
