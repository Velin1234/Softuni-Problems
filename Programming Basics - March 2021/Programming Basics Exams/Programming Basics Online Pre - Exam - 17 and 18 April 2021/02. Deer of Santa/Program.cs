using System;

namespace _02._Deer_of_Santa
{
    class Program
    {
        static void Main(string[] args)
        {
            int daysSantaAbsent = int.Parse(Console.ReadLine());
            double leftFood = int.Parse(Console.ReadLine());
            double foodPerDayDeer1 = double.Parse(Console.ReadLine());
            double foodPerDayDeer2 = double.Parse(Console.ReadLine());
            double foodPerDayDeer3 = double.Parse(Console.ReadLine());

            double eatenFood = daysSantaAbsent * foodPerDayDeer1 + daysSantaAbsent * foodPerDayDeer2 + daysSantaAbsent * foodPerDayDeer3;


            if (leftFood > eatenFood)
            {
                leftFood -= eatenFood;
                Console.WriteLine($"{Math.Floor(leftFood)} kilos of food left.");
            }
            else
            {
                eatenFood -= leftFood;
                Console.WriteLine($"{Math.Ceiling(eatenFood)} more kilos of food are needed.");
            }
        }
    }
}
