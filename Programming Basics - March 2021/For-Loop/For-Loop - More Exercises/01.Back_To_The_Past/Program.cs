using System;

namespace _01.Back_To_The_Past
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            double spentMoney = 0;
            int year = int.Parse(Console.ReadLine());
            int years = 18;
            
            for (int yearBack = 1800; yearBack <= year; yearBack++)
            {
                if (yearBack % 2 == 0)
                {
                    spentMoney += 12000;
                }
                else if(yearBack % 2 != 0)
                {
                    spentMoney += 12000 + years * 50;
                }
                years++;
            }
            
            if (money >= spentMoney)
            {
                double leftMoney = money - spentMoney;
                Console.WriteLine($"Yes! He will live a carefree life and will have {leftMoney:f2} dollars left.");
            }
            else
            {
                double neededMoney = Math.Abs(money - spentMoney);
                Console.WriteLine($"He will need {neededMoney:f2} dollars to survive.");
            }
        }
    }
}
