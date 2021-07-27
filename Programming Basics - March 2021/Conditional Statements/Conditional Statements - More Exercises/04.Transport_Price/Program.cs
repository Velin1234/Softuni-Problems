using System;

namespace _04.Transport_Price
{
    class Program
    {
        static void Main(string[] args)
        {
            double kilometers_to_travel = double.Parse(Console.ReadLine());
            string time_of_the_day = Console.ReadLine();
            double price_for_taxi = 0.70;
            double price_for_bus = 0.09 * kilometers_to_travel;
            double price_for_train = 0.06 * kilometers_to_travel;
            
            if (time_of_the_day == "day")
            {
                price_for_taxi += 0.79 * kilometers_to_travel;
            }
            else if (time_of_the_day == "night")
            {
                price_for_taxi += 0.90 * kilometers_to_travel;
            }

            if (kilometers_to_travel < 20)
            {
                Console.WriteLine($"{price_for_taxi:f2}");
            }
            else if (kilometers_to_travel >= 20 && kilometers_to_travel < 100)
            {
                if (price_for_taxi < price_for_bus)
                {
                    Console.WriteLine($"{price_for_taxi:f2}");
                }
                else
                {
                    Console.WriteLine($"{price_for_bus:f2}");
                }
            }
            else if (kilometers_to_travel >= 100)
            {
                if (price_for_taxi < price_for_bus && price_for_taxi < price_for_train)
                {
                    Console.WriteLine($"{price_for_taxi:f2}");
                }
                else if (price_for_bus < price_for_taxi && price_for_bus < price_for_train)
                {
                    Console.WriteLine($"{price_for_bus:f2}");
                }
                else
                {
                    Console.WriteLine($"{price_for_train:f2}");
                }
            }
        }
    }
}
