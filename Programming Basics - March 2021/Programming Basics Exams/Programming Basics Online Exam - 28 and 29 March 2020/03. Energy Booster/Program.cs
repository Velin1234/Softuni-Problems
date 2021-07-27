using System;

namespace _03._Energy_Booster
{
    class Program
    {
        static void Main(string[] args)
        {
            // или 
            string fruit = Console.ReadLine();
            string size = Console.ReadLine();
            int numberOfSets = int.Parse(Console.ReadLine());
            double price = 0;
            int fruitNum = 0;
            if (size == "big")
            {
                fruitNum = 5;
            }
            else if (size == "small")
            {
                fruitNum = 2;
            }
            switch (fruit)
            {
                case "Watermelon":
                    switch (size)
                    {
                        case "big":
                            price = 28.70;
                            break;

                        case "small":
                            price = 56;
                            break;
                    }
                    break;

                case "Mango":
                    switch (size)
                    {
                        case "big":
                            price = 19.60;
                            break;

                        case "small":
                            price = 36.66;
                            break;
                    }
                    break;

                case "Pineapple":
                    switch (size)
                    {
                        case "big":
                            price = 24.80;
                            break;

                        case "small":
                            price = 42.10;
                            break;
                    }
                    break;

                case "Raspberry":
                    switch (size)
                    {
                        case "big":
                            price = 15.20;
                            break;

                        case "small":
                            price = 20;
                            break;
                    }
                    break;
            }
            double pricePerSet = fruitNum * price;
            double orderPrice = pricePerSet * numberOfSets;
            if (orderPrice > 1000)
            {
                orderPrice -= orderPrice * 0.5;
            }
            else if (orderPrice >= 400 && orderPrice <= 1000)
            {
                orderPrice -= orderPrice * 0.15;
            }
            Console.WriteLine($"{orderPrice:f2} lv.");
        }
    }
}
