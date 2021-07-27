using System;

namespace _01._Agency_Profit
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int adultTickets = int.Parse(Console.ReadLine());
            int childrenTickets = int.Parse(Console.ReadLine());
            double adultTicketPrice = double.Parse(Console.ReadLine());
            double kidTicketPrice = adultTicketPrice - adultTicketPrice * 0.7;
            double tax = double.Parse(Console.ReadLine());

            double adultPrice = adultTickets * (adultTicketPrice + tax);
            double kidPrice = childrenTickets * (kidTicketPrice + tax);
            double wholePrice = adultPrice + kidPrice;
            double winnings = wholePrice * 0.2;


            Console.WriteLine($"The profit of your agency from {name} tickets is {winnings:f2} lv.");
        }
    }
}
