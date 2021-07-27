using System;

namespace _07.Toy_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            double trip_price = double.Parse(Console.ReadLine());
            int number_puzzles = int.Parse(Console.ReadLine());
            int number_dolls = int.Parse(Console.ReadLine());
            int number_bears = int.Parse(Console.ReadLine());
            int number_minions = int.Parse(Console.ReadLine());
            int number_trucks = int.Parse(Console.ReadLine());
            
            int number_toys = number_puzzles + number_dolls + number_bears + number_minions + number_trucks;
            
            double puzzles_price = number_puzzles * 2.60;
            double dolls_price = number_dolls * 3;
            double bears_price = number_bears * 4.10;
            double minions_price = number_minions * 8.20;
            double trucks_price = number_trucks * 2;

            double whole_price = puzzles_price + dolls_price + bears_price + minions_price + trucks_price;
            
            if (number_toys >= 50)
            {
                double discount = whole_price * 0.25;
                double discounted_price = whole_price - discount;
                double rent_price = discounted_price * 0.1;
                double final_price = discounted_price - rent_price;
                if (final_price >= trip_price)
                {
                    double money_left = final_price - trip_price;
                    Console.WriteLine($"Yes! {money_left:f2} lv left.");
                }
                else
                {
                    double needed_money = trip_price - final_price;
                    Console.WriteLine($"Not enough money! {needed_money:f2} lv needed.");
                }

            }
            else
            {
                double rent_price = whole_price * 0.1;
                double final_price = whole_price - rent_price; 
                if (final_price >= trip_price)
                {
                    double money_left = final_price - trip_price;
                    Console.WriteLine($"Yes! {money_left:f2} lv left.");                    
                }
                else
                {
                    double needed_money = trip_price - final_price;
                    Console.WriteLine($"Not enough money! {needed_money:f2} lv needed.");
                }
            }
        }
    }
}
