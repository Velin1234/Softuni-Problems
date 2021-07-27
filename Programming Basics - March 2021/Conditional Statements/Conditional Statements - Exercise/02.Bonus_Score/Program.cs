using System;

namespace _02.Bonus_Score
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            double bonus_points = 0;
            
            if (number <= 100)
            {
                bonus_points += 5;
            }
            else if(number > 100 && number <= 1000)
            {
                bonus_points += number * 0.2;
            }
            else if (number > 1000)
            {
                bonus_points += number * 0.1;
            }
            //More bonus points 
            if (number%2==0)
            {
                bonus_points += 1;
            }
            else if (number%10 == 5)
            {
                bonus_points += 2;
            }
            Console.WriteLine(bonus_points);
            double final_points = number + bonus_points;
            Console.WriteLine(final_points);
        }
    }
}
