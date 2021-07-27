using System;

namespace _02.Summer_Outfit
{
    class Program
    {
        static void Main(string[] args)
        {
            double degrees = double.Parse(Console.ReadLine());
            string time_of_the_day = Console.ReadLine();
            string outfit;
            string shoes;
            if (degrees >= 10 && degrees <= 18)
            {
                switch (time_of_the_day)
                {
                    case "Morning":
                        outfit = "Sweatshirt";
                        shoes = "Sneakers";
                        Console.WriteLine($"It's {degrees} degrees, get your {outfit} and {shoes}.");
                        break;

                    case "Afternoon":
                        outfit = "Shirt";
                        shoes = "Moccasins";
                        Console.WriteLine($"It's {degrees} degrees, get your {outfit} and {shoes}.");
                        break;

                    case "Evening":
                        outfit = "Shirt";
                        shoes = "Moccasins";
                        Console.WriteLine($"It's {degrees} degrees, get your {outfit} and {shoes}.");
                        break;

                    default:
                        Console.WriteLine("error");
                        break;
                }
            }
            else if(degrees > 18 && degrees <= 24)
            {
                switch (time_of_the_day)
                {
                    case "Morning":
                        outfit = "Shirt";
                        shoes = "Moccasins";
                        Console.WriteLine($"It's {degrees} degrees, get your {outfit} and {shoes}.");
                        break;

                    case "Afternoon":
                        outfit = "T-Shirt";
                        shoes = "Sandals";
                        Console.WriteLine($"It's {degrees} degrees, get your {outfit} and {shoes}.");
                        break;

                    case "Evening":
                        outfit = "Shirt";
                        shoes = "Moccasins";
                        Console.WriteLine($"It's {degrees} degrees, get your {outfit} and {shoes}.");
                        break;

                    default:
                        Console.WriteLine("error");
                        break;
                }
            }
            else if (degrees >= 25)
            {
                switch (time_of_the_day)
                {
                    case "Morning":
                        outfit = "T-Shirt";
                        shoes = "Sandals";
                        Console.WriteLine($"It's {degrees} degrees, get your {outfit} and {shoes}.");
                        break;

                    case "Afternoon":
                        outfit = "Swim Suit";
                        shoes = "Barefoot";
                        Console.WriteLine($"It's {degrees} degrees, get your {outfit} and {shoes}.");
                        break;

                    case "Evening":
                        outfit = "Shirt";
                        shoes = "Moccasins";
                        Console.WriteLine($"It's {degrees} degrees, get your {outfit} and {shoes}.");
                        break;

                    default:
                        Console.WriteLine("error");
                        break;
                }
            }
        }
    }
}
