using System;

namespace _07._Water_Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            const int waterCapacity = 255;
            int collectedWater = 0;

            for (int i = 0; i < lines; i++)
            {
                int pouredLiters = int.Parse(Console.ReadLine());
                collectedWater += pouredLiters;

                if (collectedWater > waterCapacity)
                {
                    Console.WriteLine("Insufficient capacity!");
                    collectedWater -= pouredLiters;
                }
            }
            Console.WriteLine(collectedWater);
        }
    }
}
