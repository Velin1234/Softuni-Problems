using System;

namespace _09._Spice_Must_Flow
{
    class Program
    {
        static void Main(string[] args)
        {
            int startingYield = int.Parse(Console.ReadLine());
            int collectedSpice = 0;
            int days = 0;

            if (startingYield < 100)
            {
                Console.WriteLine(days);
                Console.WriteLine(collectedSpice);
            }
            else
            {
                while (startingYield >= 100)
                {
                    days++;
                    collectedSpice += startingYield;
                    startingYield -= 10;
                }
                collectedSpice -= (days + 1) * 26;
                Console.WriteLine(days);
                Console.WriteLine(collectedSpice);
            }
        }
    }
}
