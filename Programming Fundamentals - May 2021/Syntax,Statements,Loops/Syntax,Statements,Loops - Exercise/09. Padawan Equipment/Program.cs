using System;

namespace _09._Padawan_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double priceLightsaber = double.Parse(Console.ReadLine());
            double priceRobes = double.Parse(Console.ReadLine());
            double priceBelts = double.Parse(Console.ReadLine());

            double totalLightsabers = Math.Ceiling(students + students * 0.1) * priceLightsaber;
            double totalRobes = students * priceRobes;
            int paidStudents = 0;
            for (int i = 1; i <= students; i++)
            {
                if (i % 6 != 0)
                {
                    paidStudents++;
                }
            }
            
            
            double totalBelts = paidStudents * priceBelts;

            double totalMoney = totalLightsabers + totalRobes + totalBelts;
            if (totalMoney <= money)
            {
                Console.WriteLine($"The money is enough - it would cost {totalMoney:f2}lv.");
            }
            else
            {
                totalMoney -= money;
                Console.WriteLine($"John will need {totalMoney:f2}lv more.");
            }
        }
    }
}
