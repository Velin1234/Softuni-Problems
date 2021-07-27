using System;

namespace _02._Add_Bags
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceAbove20Kg = double.Parse(Console.ReadLine());
            double BaggageKg = double.Parse(Console.ReadLine());
            int travelDays = int.Parse(Console.ReadLine());
            int numberBaggages = int.Parse(Console.ReadLine());

            if (BaggageKg < 10)
            {
                priceAbove20Kg *= 0.2;
            }
            else if (BaggageKg >= 10 && BaggageKg <= 20)
            {
                priceAbove20Kg /= 2;
            }
            else if (BaggageKg > 20)
            {
                
            }

            if (travelDays > 30)
            {
                priceAbove20Kg += priceAbove20Kg * 0.1;
            }
            else if (travelDays >= 7 && travelDays <= 30)
            {
                priceAbove20Kg += priceAbove20Kg * 0.15;
            }
            else if (travelDays < 7)
            {
                priceAbove20Kg += priceAbove20Kg * 0.4;
            }

            double moneyToPay = numberBaggages * priceAbove20Kg;

            Console.WriteLine($"The total price of bags is: {moneyToPay:f2} lv.");

        }
    }
}
