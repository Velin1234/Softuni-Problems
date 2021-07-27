using System;

namespace _02._Mountain_Run
{
    class Program
    {
        static void Main(string[] args)
        {
            double recordTime = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double timePer1m = double.Parse(Console.ReadLine());

            double personalTime = distance * timePer1m;
            personalTime += Math.Floor((distance / 50)) * 30;
            if (recordTime > personalTime)
            {
                Console.WriteLine($"Yes! The new record is {personalTime:f2} seconds.");
            }
            else
            {
                double neededTime = personalTime - recordTime;
                Console.WriteLine($"No! He was {neededTime:f2} seconds slower.");
            }
        }
    }
}
