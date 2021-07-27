using System;

namespace _06.Bills
{
    class Program
    {
        static void Main(string[] args)
        {
            const decimal waterMonthlyPrice = 20;
            const decimal internetMonthlyPrice = 15;
            decimal electricityPrice = 0;
            decimal otherPrice = 0;
            int months = int.Parse(Console.ReadLine());

            for (int month = 1; month <= months; month++)
            {
                decimal electricityMonthlyPrice = decimal.Parse(Console.ReadLine());
                electricityPrice += electricityMonthlyPrice;
                decimal otherMonthlyPrice = (electricityMonthlyPrice + waterMonthlyPrice + internetMonthlyPrice) + (electricityMonthlyPrice + waterMonthlyPrice + internetMonthlyPrice) * 20/100;
                otherPrice += otherMonthlyPrice;
            }

            decimal waterPrice = months * waterMonthlyPrice;
            decimal internetPrice = months * internetMonthlyPrice;
            decimal avgPrice = (electricityPrice + waterPrice + internetPrice + otherPrice) / months;

            Console.WriteLine($"Electricity: {electricityPrice:f2} lv");
            Console.WriteLine($"Water: {waterPrice:f2} lv");
            Console.WriteLine($"Internet: {internetPrice:f2} lv");
            Console.WriteLine($"Other: {otherPrice:f2} lv");
            Console.WriteLine($"Average: {avgPrice:f2} lv");

        }
    }
}
