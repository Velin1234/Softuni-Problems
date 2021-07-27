using System;

namespace _01._Computer_Store
{
    class Program
    {
        static void Main(string[] args)
        {
            string prices = Console.ReadLine();
            double partsPrice = 0;

            while (true)
            {
                if (prices == "special" || prices == "regular")
                {
                    break;
                }
                else
                {
                    if (Convert.ToDouble(prices) > 0)
                    {
                        partsPrice += Convert.ToDouble(prices);
                    }
                    else
                    {
                        Console.WriteLine("Invalid price!");
                    }
                }
                
                prices = Console.ReadLine();
                
            }
            
            double taxes = partsPrice * 0.2;
            double totalPrice = partsPrice + taxes;
            if (prices == "special")
            {
                totalPrice = totalPrice - totalPrice * 0.1;
            }

            if (totalPrice <= 0)
            {
                Console.WriteLine("Invalid order!");
            }
            else
            {
                Console.WriteLine("Congratulations you've just bought a new computer! \n" +
                $"Price without taxes: {partsPrice:f2}$\n" +
                $"Taxes: {taxes:f2}$\n" +
                "-----------\n" +
                $"Total price: {totalPrice:f2}$");
            }
        }
    }
}
