using System;

namespace _11.Clever_Lily
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double priceWashingMachine = double.Parse(Console.ReadLine());
            int toysPrice = int.Parse(Console.ReadLine());

            int numberOfToys = 0;
            int savedMoney = 0;
            int moneyForBirthday = 10;

            for (int currentYear = 1; currentYear <= age; currentYear++)
            {
                if (currentYear % 2 ==0)
                {
                    savedMoney += (moneyForBirthday - 1);
                    moneyForBirthday += 10;
                }
                else
                {
                    numberOfToys++;
                }
            }
            savedMoney += numberOfToys * toysPrice;
            if (savedMoney>= priceWashingMachine)
            {
                Console.WriteLine($"Yes! {(savedMoney - priceWashingMachine):f2}");
            }
            else
            {
                Console.WriteLine($"No! {(priceWashingMachine - savedMoney):f2}");
            }
        }
    }
}
