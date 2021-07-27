using System;

namespace _05._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string order = Console.ReadLine();
            int quanity = int.Parse(Console.ReadLine());
            double total = 0;
            switch (order)
            {
                case "coffee":
                    total = OrderCoffee(quanity);
                    break;
                case "water":
                    total = OrderWatter(quanity);
                    break;
                case "coke":
                    total = OrderCoke(quanity);
                    break;
                case "snacks":
                    total = OrderSnacks(quanity);
                    break;

            }
            Console.WriteLine($"{total:f2}");
        }

        private static double OrderSnacks(int quanity)
        {
            return quanity * 2;
        }

        private static double OrderCoke(int quanity)
        {
            return quanity * 1.4;
        }

        private static double OrderWatter(int quanity)
        {
            return quanity * 1;
        }

        static double OrderCoffee(int quanity)
        {
            return quanity * 1.5;
        }
    }
}
