using System;

namespace _13.Ski_Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            int days_booked = int.Parse(Console.ReadLine());
            int nights_slept = days_booked - 1;
            
            string room_booked = Console.ReadLine();
            string rate = Console.ReadLine();

            int roomForOne = 18;
            int apartment = 25;
            int president = 35;

            decimal totalSum = 0;

            switch (room_booked)
            {
                case "room for one person":
                    totalSum = nights_slept * roomForOne;
                    break;
                case "apartment":
                    totalSum = nights_slept * apartment;
                    if (nights_slept < 10)
                    {
                        totalSum *= 0.7M;
                    }
                    else if (nights_slept >= 10 && nights_slept <= 15)
                    {
                        totalSum *= 0.65M;
                    }
                    else if (nights_slept > 15)
                    {
                        totalSum *= 0.5M;
                    }
                    break;
                case "president apartment":
                    totalSum = nights_slept * president;
                    if (nights_slept < 10)
                    {
                        totalSum *= 0.9M;
                    }
                    else if (nights_slept >= 10 && nights_slept <= 15)
                    {
                        totalSum *= 0.85M;
                    }
                    else if (nights_slept > 15)
                    {
                        totalSum *= 0.8M;
                    }
                    break;
                default:
                    break;
            }

            if (rate == "positive")
            {
                totalSum += totalSum * 0.25M;
            }
            else
            {
                totalSum -= totalSum * 0.1M;
            }

            Console.WriteLine($"{totalSum:f2}");
        
        }
    }
}            
