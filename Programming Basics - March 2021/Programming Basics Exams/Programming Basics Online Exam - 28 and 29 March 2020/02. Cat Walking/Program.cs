using System;

namespace _02._Cat_Walking
{
    class Program
    {
        static void Main(string[] args)
        {
            int minutesForAWalk = int.Parse(Console.ReadLine());
            int numberOfWalks = int.Parse(Console.ReadLine());
            int caloriesIntake = int.Parse(Console.ReadLine());

            int wholeDayMinutes = minutesForAWalk * numberOfWalks;
            int caloriesBurned = wholeDayMinutes * 5;

            if (caloriesBurned >= caloriesIntake / 2)
            {
                Console.WriteLine($"Yes, the walk for your cat is enough. Burned calories per day: {caloriesBurned}.");
            }
            else
            {
                Console.WriteLine($"No, the walk for your cat is not enough. Burned calories per day: {caloriesBurned}.");
            }
        }
    }
}
