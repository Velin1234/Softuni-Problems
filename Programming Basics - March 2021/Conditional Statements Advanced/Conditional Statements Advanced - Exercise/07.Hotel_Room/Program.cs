using System;

namespace _07.Hotel_Room
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nights_spent = int.Parse(Console.ReadLine());
            double apartment_price;
            double studio_price;
            double apartment_sum;
            double studio_sum;

            if (nights_spent <= 7)
            {
                switch (month)
                {
                    case "May":
                    case "October":
                        apartment_price = 65;
                        studio_price = 50;

                        apartment_sum = nights_spent * apartment_price;
                        studio_sum = nights_spent * studio_price;

                        Console.WriteLine($"Apartment: {apartment_sum:f2} lv.");
                        Console.WriteLine($"Studio: {studio_sum:f2} lv.");
                        break;

                    case "June":
                    case "September":
                        apartment_price = 68.70;
                        studio_price = 75.20;

                        apartment_sum = nights_spent * apartment_price;
                        studio_sum = nights_spent * studio_price;

                        Console.WriteLine($"Apartment: {apartment_sum:f2} lv.");
                        Console.WriteLine($"Studio: {studio_sum:f2} lv.");
                        break;

                    case "July":
                    case "August":
                        apartment_price = 77;
                        studio_price = 76;

                        apartment_sum = nights_spent * apartment_price;
                        studio_sum = nights_spent * studio_price;

                        Console.WriteLine($"Apartment: {apartment_sum:f2} lv.");
                        Console.WriteLine($"Studio: {studio_sum:f2} lv.");
                        break;
                }
            }
            else if (nights_spent > 7 && nights_spent <= 14)
            {
                switch (month)
                {
                    case "May":
                    case "October":
                        apartment_price = 65;
                        studio_price = 50;

                        apartment_sum = nights_spent * apartment_price;
                        studio_sum = nights_spent * studio_price;
                        studio_sum -= studio_sum * 0.05;

                        Console.WriteLine($"Apartment: {apartment_sum:f2} lv.");
                        Console.WriteLine($"Studio: {studio_sum:f2} lv.");
                        break;

                    case "June":
                    case "September":
                        apartment_price = 68.70;
                        studio_price = 75.20;

                        apartment_sum = nights_spent * apartment_price;
                        studio_sum = nights_spent * studio_price;

                        Console.WriteLine($"Apartment: {apartment_sum:f2} lv.");
                        Console.WriteLine($"Studio: {studio_sum:f2} lv.");
                        break;

                    case "July":
                    case "August":
                        apartment_price = 77;
                        studio_price = 76;

                        apartment_sum = nights_spent * apartment_price;
                        studio_sum = nights_spent * studio_price;

                        Console.WriteLine($"Apartment: {apartment_sum:f2} lv.");
                        Console.WriteLine($"Studio: {studio_sum:f2} lv.");
                        break;
                }
            }
            else if (nights_spent > 14)
            {
                switch (month)
                {
                    case "May":
                    case "October":
                        apartment_price = 65;
                        studio_price = 50;

                        apartment_sum = nights_spent * apartment_price;
                        studio_sum = nights_spent * studio_price;
                        studio_sum -= studio_sum * 0.3;
                        apartment_sum -= apartment_sum * 0.1;

                        Console.WriteLine($"Apartment: {apartment_sum:f2} lv.");
                        Console.WriteLine($"Studio: {studio_sum:f2} lv.");
                        break;

                    case "June":
                    case "September":
                        apartment_price = 68.70;
                        studio_price = 75.20;

                        apartment_sum = nights_spent * apartment_price;
                        studio_sum = nights_spent * studio_price;
                        studio_sum -= studio_sum * 0.2;
                        apartment_sum -= apartment_sum * 0.1;
                        
                        Console.WriteLine($"Apartment: {apartment_sum:f2} lv.");
                        Console.WriteLine($"Studio: {studio_sum:f2} lv.");
                        break;

                    case "July":
                    case "August":
                        apartment_price = 77;
                        studio_price = 76;
                        
                        apartment_sum = nights_spent * apartment_price;
                        studio_sum = nights_spent * studio_price;
                        apartment_sum -= apartment_sum * 0.1;

                        Console.WriteLine($"Apartment: {apartment_sum:f2} lv.");
                        Console.WriteLine($"Studio: {studio_sum:f2} lv.");
                        break;
                }
            }
        }
    }
}
