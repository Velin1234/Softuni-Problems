using System;

namespace _01.Match_Tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            const double VIP_ticket = 499.99;
            const double normal_ticket = 249.99;

            double budget = double.Parse(Console.ReadLine());
            string category_ticket = Console.ReadLine();
            int number_of_people = int.Parse(Console.ReadLine());

            double tickets_price = 0;
            
            switch (category_ticket)
            {
                case "VIP":
                    tickets_price = VIP_ticket * number_of_people;
                    break;
                
                case "Normal":
                    tickets_price = normal_ticket * number_of_people;
                    break;

                default:
                    break;
            }
            
            if (number_of_people >= 1 && number_of_people <= 4)
            {
                budget -= budget * 0.75;
            }
            else if(number_of_people >= 5 && number_of_people <= 9)
            {
                budget -= budget * 0.6;
            }
            else if (number_of_people >= 10 && number_of_people <= 24)
            {
                budget -= budget * 0.5;
            }
            else if (number_of_people >= 25 && number_of_people <= 49)
            {
                budget -= budget * 0.4;
            }
            else if (number_of_people >= 50)
            {
                budget -= budget * 0.25;
            }

            if (budget >= tickets_price)
            {
                double left_money = budget - tickets_price;
                Console.WriteLine($"Yes! You have {left_money:f2} leva left.");
            }
            else
            {
                double needed_money = Math.Abs(budget - tickets_price);
                Console.WriteLine($"Not enough money! You need {needed_money:f2} leva.");
            }
        }
    }
}
