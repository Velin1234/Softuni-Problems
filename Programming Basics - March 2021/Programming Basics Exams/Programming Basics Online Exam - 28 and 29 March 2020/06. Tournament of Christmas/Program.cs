using System;

namespace _06._Tournament_of_Christmas
{
    class Program
    {
        static void Main(string[] args)
        {
            int tournamentDays = int.Parse(Console.ReadLine());
            double money = 0;
            int wins = 0;
            int loses = 0;
            for (int i = 1; i <= tournamentDays; i++)
            {
                double perDayMoney = 0;
                string sport = Console.ReadLine();
                int winsPerDay = 0;
                int losesPerDay = 0;
                while (sport != "Finish")
                {
                    string W_L = Console.ReadLine();
                    if (W_L == "win")
                    {
                        perDayMoney += 20;
                        winsPerDay++;
                    }
                    else
                    {
                        losesPerDay++;
                    }
                    sport = Console.ReadLine();
                }

                if (winsPerDay > losesPerDay)
                {
                    perDayMoney += perDayMoney * 0.1;
                }
                money += perDayMoney;
                wins += winsPerDay;
                loses += losesPerDay;
                winsPerDay = 0;
                losesPerDay = 0;
                perDayMoney = 0;
            }
            if (wins > loses)
            {
                money += money * 0.2;
                Console.WriteLine($"You won the tournament! Total raised money: {money:f2}");
            }
            else
            {
                Console.WriteLine($"You lost the tournament! Total raised money: {money:f2}");
            }
        }
    }
}
