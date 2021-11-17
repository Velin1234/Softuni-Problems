using System;
using System.Collections.Generic;

namespace FoodShortage
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int foodBought = 0;
            int numberOfPeople = int.Parse(Console.ReadLine());
            List<IBuyer> buyers = new List<IBuyer>();
            for (int i = 0; i < numberOfPeople; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                if (input.Length == 4)
                {
                    Citizen citizen = new Citizen(input[0], int.Parse(input[1]), input[2], input[3]);
                    buyers.Add(citizen);
                }
                else if (input.Length == 3)
                {
                    Rebel rebel = new Rebel(input[0], int.Parse(input[1]), input[2]);
                    buyers.Add(rebel);
                }
            }

            string buyerName = Console.ReadLine();
            while (buyerName != "End")
            {
                foreach (var buyer in buyers)
                {
                    if (buyer.Name == buyerName)
                    {
                        foodBought += buyer.BuyFood();
                    }
                }
                buyerName = Console.ReadLine();
            }
            Console.WriteLine(foodBought);
        }
    }
}
