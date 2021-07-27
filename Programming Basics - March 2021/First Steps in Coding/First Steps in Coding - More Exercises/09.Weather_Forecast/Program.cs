using System;

namespace _09.Weather_Forecast
{
    class Program
    {
        static void Main(string[] args)
        {
            string prediction = Console.ReadLine();
            if (prediction == "sunny")
            {
                Console.WriteLine("It's warm outside!");
            }
            else
            {
                Console.WriteLine("It's cold outside!");
            }
        }
    }
}
