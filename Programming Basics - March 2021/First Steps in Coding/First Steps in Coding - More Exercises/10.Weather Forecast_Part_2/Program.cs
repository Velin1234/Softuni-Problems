using System;

namespace _10.Weather_Forecast_Part_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double temperature = double.Parse(Console.ReadLine());

            if (temperature <= 35 && temperature >= 26)
            {
                Console.WriteLine("Hot");
            }
            else if (temperature <= 25.9 && temperature >= 20.1)
            {
                Console.WriteLine("Warm");
            }
            else if (temperature <= 20 && temperature >= 15  )
            {
                Console.WriteLine("Mild");
            }
            else if (temperature <= 14.9 && temperature >= 12)
            {
                Console.WriteLine("Cool");
            }
            else if (temperature <= 11.9 && temperature >= 5)
            {
                Console.WriteLine("Cold");
            }
            else
            {
                Console.WriteLine("unknown");
            }
        }
    }
}
