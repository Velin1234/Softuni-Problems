using System;

namespace _04.Car_To_Go
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            if (budget <= 100)
            {
                Console.WriteLine("Economy class");
                switch (season)
                {
                    case "Summer":
                        budget = budget * 0.35;
                        Console.WriteLine($"Cabrio - {budget:f2}");
                            break;
                    
                    case "Winter":
                        budget = budget * 0.65;
                        Console.WriteLine($"Jeep - {budget:f2}");
                        break;
                }
            }
            else if(budget > 100 && budget <= 500)
            {
                Console.WriteLine("Compact class");
                switch (season)
                {
                    case "Summer":
                        budget = budget * 0.45;
                        Console.WriteLine($"Cabrio - {budget:f2}");
                        break;

                    case "Winter":
                        budget = budget * 0.80;
                        Console.WriteLine($"Jeep - {budget:f2}");
                        break;
                }
            }
            else if(budget > 500)
            {
                Console.WriteLine("Luxury class");
                budget = budget * 0.9;
                Console.WriteLine($"Jeep - {budget:f2}");
            }
        }
    }
}
