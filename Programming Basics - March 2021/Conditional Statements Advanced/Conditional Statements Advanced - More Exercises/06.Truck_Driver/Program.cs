using System;

namespace _06.Truck_Driver
{
    class Program
    {
        static void Main(string[] args)
        {

            string season = Console.ReadLine();
            double monthlyKm = double.Parse(Console.ReadLine());
            double monthlySalary = 0; 

            if (monthlyKm <= 5000)
            {
                switch (season)
                {
                    case "Spring":
                    case "Autumn":
                        monthlySalary = monthlyKm * 0.75;
                        break;
                    case "Summer":
                        monthlySalary = monthlyKm * 0.90;
                        break;
                    case "Winter":
                        monthlySalary = monthlyKm * 1.05;
                        break;
                }
            }
            else if (monthlyKm > 5000 && monthlyKm <= 10000)
            {
                switch (season)
                {
                    case "Spring":
                    case "Autumn":
                        monthlySalary = monthlyKm * 0.95;
                        break;
                    case "Summer":
                        monthlySalary = monthlyKm * 1.10;
                        break;
                    case "Winter":
                        monthlySalary = monthlyKm * 1.25;
                        break;
                }
            }
            else if (10000 < monthlyKm && monthlyKm <= 20000)
            {
                switch (season)
                {
                    case "Spring":
                    case "Autumn":
                    case "Summer":
                    case "Winter":
                        monthlySalary = monthlyKm * 1.45;
                        break;
                }
            }
            double seasonSalary = monthlySalary * 4;
            seasonSalary -= seasonSalary * 0.1;
            Console.WriteLine($"{seasonSalary:f2}");
        }
    }
}
