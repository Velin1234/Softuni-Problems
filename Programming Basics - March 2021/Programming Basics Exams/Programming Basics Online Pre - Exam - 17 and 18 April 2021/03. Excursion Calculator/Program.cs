using System;

namespace _03._Excursion_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            double pricePerPerson = 0;

            switch (season)
            {
                case "spring":
                    if (people <= 5)
                    {
                        pricePerPerson = 50;
                    }
                    else if (people > 5)
                    {
                        pricePerPerson = 48;
                    }
                    break;

                case "summer":
                    if (people <= 5)
                    {
                        pricePerPerson = 48.50;
                    }
                    else if (people > 5)
                    {
                        pricePerPerson = 45;
                    }
                    break;

                case "autumn":
                    if (people <= 5)
                    {
                        pricePerPerson = 60;
                    }
                    else if (people > 5)
                    {
                        pricePerPerson = 49.50;
                    }
                    break;

                case "winter":
                    if (people <= 5)
                    {
                        pricePerPerson = 86;
                    }
                    else if (people > 5)
                    {
                        pricePerPerson = 85;
                    }
                    break;
            }

            double finalPrice = pricePerPerson * people;
            if (season=="summer")
            {
                finalPrice -= finalPrice * 0.15;
            }
            else if(season == "winter")
            {
                finalPrice += finalPrice * 0.08;
            }

            Console.WriteLine($"{finalPrice:f2} leva.");
        }
    }
}
