using System;

namespace _04._Workout
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            double ranFirstDayKm = double.Parse(Console.ReadLine());
            double ranKm = 0;
            
            for (int i = 1; i <= days; i++)
            {
                ranKm += ranFirstDayKm;
                double percentsIncrease = double.Parse(Console.ReadLine());
                ranFirstDayKm += ranFirstDayKm * percentsIncrease / 100;
            }
            ranKm += ranFirstDayKm;
            if (ranKm >= 1000)
            {
                ranKm -= 1000;
                Console.WriteLine($"You've done a great job running {Math.Ceiling(ranKm)} more kilometers!");
            }
            else
            {
                double neededKm = 1000 - ranKm;
                Console.WriteLine($"Sorry Mrs. Ivanova, you need to run {Math.Ceiling(neededKm)} more kilometers");
            }
        }
    }
}
