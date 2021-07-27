using System;

namespace _07.Football_League
{
    class Program
    {
        static void Main(string[] args)
        {
            double stadiumCapacity = double.Parse(Console.ReadLine());
            double numberOfFans= double.Parse(Console.ReadLine());
            double sectorA = 0;
            double sectorB = 0;
            double sectorV = 0;
            double sectorG = 0;

            for (int fan = 1; fan <= numberOfFans; fan++)
            {
                string sector = Console.ReadLine();
                switch (sector)
                {
                    case "A":
                        sectorA++;
                        break;
                    case "B":
                        sectorB++;
                        break;
                    case "V":
                        sectorV++;
                        break;
                    case "G":
                        sectorG++;
                        break;
                }
            }
            double sectorAPercentage = sectorA / numberOfFans * 100;
            double sectorBPercentage = sectorB / numberOfFans * 100;
            double sectorVPercentage = sectorV / numberOfFans * 100;
            double sectorGPercentage = sectorG / numberOfFans * 100;
            double filledCapacity = numberOfFans / stadiumCapacity * 100;
        
            Console.WriteLine($"{sectorAPercentage:f2}%");
            Console.WriteLine($"{sectorBPercentage:f2}%");
            Console.WriteLine($"{sectorVPercentage:f2}%");
            Console.WriteLine($"{sectorGPercentage:f2}%");
            Console.WriteLine($"{filledCapacity:f2}%");
        
        }
    }
}
