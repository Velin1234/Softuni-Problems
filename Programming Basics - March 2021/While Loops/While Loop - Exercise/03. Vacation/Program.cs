using System;

namespace _03._Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal moneyNeeded = decimal.Parse(Console.ReadLine());
            decimal availableMoney = decimal.Parse(Console.ReadLine());

            int daysCounter = 0;
            int spendingCounter = 0;

            while (availableMoney < moneyNeeded && spendingCounter < 5)
            {
                string activity = Console.ReadLine();
                decimal amount = decimal.Parse(Console.ReadLine());
                daysCounter++;
                
                if (activity == "save")
                {
                    availableMoney += amount;
                    spendingCounter = 0;
                }
                else if (activity == "spend")
                {
                    if (availableMoney >= amount)
                    {
                        availableMoney -= amount;
                    }
                    else
                    {
                        availableMoney = 0;
                    }
                    spendingCounter++;
                }
            }
            
            if (spendingCounter == 5)
            {
                Console.WriteLine("You can't save the money.");
                Console.WriteLine(daysCounter);
            }
            if (availableMoney >= moneyNeeded)
            {
                Console.WriteLine($"You saved the money for {daysCounter} days.");
            }
        }
    }
}
