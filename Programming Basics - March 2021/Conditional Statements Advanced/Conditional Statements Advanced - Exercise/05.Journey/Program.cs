using System;

namespace _05.Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            double summer_budget;
            double winter_budget;

            if (budget <= 100)
            {
                switch (season)
                {
                    case "summer":
                        summer_budget = budget * 0.3;
                        Console.WriteLine("Somewhere in Bulgaria");
                        Console.WriteLine($"Camp - {summer_budget:f2}");
                        break;
                    case "winter":
                        winter_budget = budget * 0.7;
                        Console.WriteLine("Somewhere in Bulgaria");
                        Console.WriteLine($"Hotel - {winter_budget:f2}");
                        break;
                }
            }
            else if(budget > 100 && budget <= 1000)
            {
                switch (season)
                {
                    case "summer":
                        summer_budget = budget * 0.4;
                        Console.WriteLine("Somewhere in Balkans");
                        Console.WriteLine($"Camp - {summer_budget:f2}");
                        break;
                    case "winter":
                        winter_budget = budget * 0.8;
                        Console.WriteLine("Somewhere in Balkans");
                        Console.WriteLine($"Hotel - {winter_budget:f2}");
                        break;
                }
            }
            else if(budget > 1000)
            {
                switch (season)
                {
                    case "summer":
                        summer_budget = budget * 0.9;
                        Console.WriteLine("Somewhere in Europe");
                        Console.WriteLine($"Hotel - {summer_budget:f2}");
                        break;
                    case "winter":
                        winter_budget = budget * 0.9;
                        Console.WriteLine("Somewhere in Europe");
                        Console.WriteLine($"Hotel - {winter_budget:f2}");
                        break;
                }
            }
        }
    }
}
