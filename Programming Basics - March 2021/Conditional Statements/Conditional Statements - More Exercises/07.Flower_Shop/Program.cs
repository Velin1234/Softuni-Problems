using System;

namespace _07.Flower_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            //magnolia = магнолия; hyacinth = зюмбюл;  

            int number_of_magnolias = int.Parse(Console.ReadLine());
            int number_of_hyacinths = int.Parse(Console.ReadLine());
            int number_of_roses= int.Parse(Console.ReadLine());
            int number_of_cactuses = int.Parse(Console.ReadLine());
            double price_of_present = double.Parse(Console.ReadLine());

            double price_magnolias = number_of_magnolias * 3.25;
            double price_hyacinths = number_of_hyacinths * 4;
            double price_roses = number_of_roses * 3.50;
            double price_cactuses = number_of_cactuses * 8;

            double whole_price = price_magnolias + price_hyacinths + price_roses + price_cactuses;
            whole_price -= whole_price * 0.05;
            
            if (price_of_present > whole_price)
            {
                double needed_money = price_of_present - whole_price;
                Console.WriteLine($"She will have to borrow {Math.Ceiling(needed_money)} leva.");
            }
            else
            {
                double extra_money = whole_price - price_of_present;
                Console.WriteLine($"She is left with {Math.Floor(extra_money)} leva.");
            }
        }
    }
}
