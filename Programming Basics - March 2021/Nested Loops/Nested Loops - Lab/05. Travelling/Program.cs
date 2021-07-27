using System;

namespace _05._Travelling
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string place = Console.ReadLine();
                var neededAmount = Console.ReadLine();
                double collectedAmount = 0;

                if (place == "End" || neededAmount == "End")
                {
                    break;
                }

                while (collectedAmount < Convert.ToDouble(neededAmount))
                {
                    double amount = double.Parse(Console.ReadLine());
                    collectedAmount += amount;
                }
                if (collectedAmount >=Convert.ToDouble(neededAmount))
                {
                    Console.WriteLine($"Going to {place}!");
                }
            }

        }
    }
}
