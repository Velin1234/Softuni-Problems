using System;

namespace _05.Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string placeToStay = "";
            string location = "";

            if (budget <= 1000)
            {
                placeToStay = "Camp";
                switch (season)
                {
                    
                    case "Summer":
                        location = "Alaska";
                        budget = budget * 0.65;
                        Console.WriteLine($"{location} - {placeToStay} - {budget:f2}");
                        break;
                    
                    case "Winter":
                        location = "Morocco";
                        budget = budget * 0.45;
                        Console.WriteLine($"{location} - {placeToStay} - {budget:f2}");
                        break;
                }
            }
            else if (budget > 1000 && budget <= 3000)
            {
                placeToStay = "Hut";
                switch (season)
                {

                    case "Summer":
                        location = "Alaska";
                        budget = budget * 0.80;
                        Console.WriteLine($"{location} - {placeToStay} - {budget:f2}");
                        break;

                    case "Winter":
                        location = "Morocco";
                        budget = budget * 0.60;
                        Console.WriteLine($"{location} - {placeToStay} - {budget:f2}");
                        break;
                }
            }
            else if (budget > 3000)
            {
                placeToStay = "Hotel";
                budget = budget * 0.90;
                switch (season)
                {
                   
                    case "Summer":
                        location = "Alaska";
                        Console.WriteLine($"{location} - {placeToStay} - {budget:f2}");
                        break;

                    case "Winter":
                        location = "Morocco";
                        Console.WriteLine($"{location} - {placeToStay} - {budget:f2}");
                        break;
                }
            }
        }
    }
}
