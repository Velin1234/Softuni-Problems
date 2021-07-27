using System;

namespace _05.Small_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string town = Console.ReadLine();
            double quanity = double.Parse(Console.ReadLine());
            if (town == "Sofia")
            {
                switch (product)
                {
                    case "coffee":
                        Console.WriteLine(quanity * 0.5);
                        break;
                    
                    case "water":
                        Console.WriteLine(quanity * 0.8);
                        break;
                    
                    case "beer":
                        Console.WriteLine(quanity * 1.2);
                        break;

                    case "sweets":
                        Console.WriteLine(quanity *1.45);
                        break;

                    case "peanuts":
                        Console.WriteLine(quanity * 1.6);
                        break;
                }
            }
            else if (town == "Plovdiv")
            {
                switch (product)
                {
                    case "coffee":
                        Console.WriteLine(quanity * 0.4);
                        break;

                    case "water":
                        Console.WriteLine(quanity * 0.7);
                        break;

                    case "beer":
                        Console.WriteLine(quanity * 1.15);
                        break;

                    case "sweets":
                        Console.WriteLine(quanity * 1.30);
                        break;

                    case "peanuts":
                        Console.WriteLine(quanity * 1.50);
                        break;
                }

            }
            else if (town == "Varna")
            {
                switch (product)
                {
                    case "coffee":
                        Console.WriteLine(quanity * 0.45);
                        break;

                    case "water":
                        Console.WriteLine(quanity * 0.7);
                        break;

                    case "beer":
                        Console.WriteLine(quanity * 1.1);
                        break;

                    case "sweets":
                        Console.WriteLine(quanity * 1.35);
                        break;

                    case "peanuts":
                        Console.WriteLine(quanity * 1.55);
                        break;
                }
            }
        }
    }
}
