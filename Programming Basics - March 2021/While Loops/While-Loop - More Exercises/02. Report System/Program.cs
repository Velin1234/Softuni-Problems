using System;

namespace _02._Report_System
{
    class Program
    {
        static void Main(string[] args)
        {
            int neededMoney = int.Parse(Console.ReadLine());
            int collectedMoney = 0;
            int counter = 1;
            int creditCardPerson = 0;
            int pocketMoneyPerson = 0;
            double collectedCreditCardMoney = 0;
            double collectedPocketMoney = 0;

            while (collectedMoney < neededMoney)
            {
                var command = Console.ReadLine();
                if (command == "End")
                {
                    break;
                }

                if (counter == 2)
                {
                    if (Convert.ToInt32(command) >= 10)
                    {
                        Console.WriteLine("Product sold!");
                        collectedMoney += Convert.ToInt32(command);
                        collectedCreditCardMoney += Convert.ToDouble(command);
                        creditCardPerson++;
                    }
                    else
                    {
                        Console.WriteLine("Error in transaction!");
                    }
                    counter = 1;
                }
                else
                {
                    if (Convert.ToInt32(command) <= 100)
                    {
                        Console.WriteLine("Product sold!");
                        collectedMoney += Convert.ToInt32(command);
                        collectedPocketMoney += Convert.ToDouble(command);
                        pocketMoneyPerson++;
                    }
                    else
                    {
                        Console.WriteLine("Error in transaction!");
                    }
                    counter++;
                }

                if (collectedMoney >= neededMoney)
                {
                    break;
                }
            }

            double avgMoneyCS = collectedPocketMoney / pocketMoneyPerson;
            double avgMoneyCC = collectedCreditCardMoney / creditCardPerson;

            if (neededMoney <= collectedMoney)
            {
                Console.WriteLine($"Average CS: {avgMoneyCS:f2}");
                Console.WriteLine($"Average CC: {avgMoneyCC:f2}");

            }
            else
            {
                Console.WriteLine("Failed to collect required money for charity.");
            }
        }
    }
}
