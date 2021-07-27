using System;

namespace _9.Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            string year = Console.ReadLine();
            double holidays_in_the_year = double.Parse(Console.ReadLine());
            double weekends_he_travels = double.Parse(Console.ReadLine());

            double holiday_games = holidays_in_the_year * 2 / 3;
            int weeks_in_a_year = 48;
            double saturday_days_in_sofia = (weeks_in_a_year - weekends_he_travels) * 3 / 4;

            double altogether_games = holiday_games + saturday_days_in_sofia + weekends_he_travels;
            
            if (year =="leap")
            {
                double leap_games = altogether_games + altogether_games * 0.15;
                Console.WriteLine(Math.Floor(leap_games));
            }
            else if(year == "normal")
            {
                Console.WriteLine(Math.Floor(altogether_games));
            }

        }
    }
}
