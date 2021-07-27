using System;

namespace _03._Aluminum_Joinery
{
    class Program
    {
        static void Main(string[] args)
        {
            double numberOfDogrami = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string wayOfDelivery = Console.ReadLine();
            double pricePerNum = 0;
            double price = 0;

            switch (type)
            {
                case "90X130":
                    pricePerNum = 110;
                    price = numberOfDogrami * pricePerNum;
                    if (numberOfDogrami >= 30 && numberOfDogrami < 60)
                    {
                        price -= price * 0.05;
                    }
                    else if (numberOfDogrami >= 60)
                    {
                        price -= price * 0.08;
                    }
                    break;

                case "100X150":
                    pricePerNum = 140;
                    price = numberOfDogrami * pricePerNum;
                    if (numberOfDogrami >= 40 && numberOfDogrami < 80)
                    {
                        price -= price * 0.06;
                    }
                    else if (numberOfDogrami >= 80)
                    {
                        price -= price * 0.1;
                    }
                    break;

                case "130X180":
                    pricePerNum = 190;
                    price = numberOfDogrami * pricePerNum;
                    if (numberOfDogrami > 20 && numberOfDogrami < 50)
                    {
                        price -= price * 0.07;
                    }
                    else if (numberOfDogrami > 50)
                    {
                        price -= price * 0.12;
                    }
                    break;

                case "200X300":
                    pricePerNum = 250; price = numberOfDogrami * pricePerNum;
                    if (numberOfDogrami > 25 && numberOfDogrami < 50)
                    {
                        price -= price * 0.09;
                    }
                    else if (numberOfDogrami > 50)
                    {
                        price -= price * 0.14;
                    }
                    break;
            }
            if (wayOfDelivery == "With delivery")
            {
                price += 60;
            }
            if (numberOfDogrami < 10)
            {
                Console.WriteLine("Invalid order");
                Environment.Exit(0);
            }
            else if (numberOfDogrami > 99)
            {
                price -= price * 0.04;
            }

            

            Console.WriteLine($"{price:f2} BGN");
        }
    }
}
