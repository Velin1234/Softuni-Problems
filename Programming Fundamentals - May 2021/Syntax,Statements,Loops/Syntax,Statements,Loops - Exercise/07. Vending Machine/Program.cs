using System;

namespace _07._Vending_Machine
{
    class Program
    {
        static void Main(string[] args)
        {
            var command = Console.ReadLine();
            double money = 0;
            while (true)
            {
                if (command == "Start")
                {
                    string product = Console.ReadLine();
                    while (product !="End")
                    {
                        switch (product)
                        {
                            case "Nuts":
                                if (money >= 2)
                                {
                                    money -= 2;
                                    Console.WriteLine("Purchased nuts");
                                }
                                else
                                {
                                    Console.WriteLine("Sorry, not enough money");
                                }
                                break;

                            case "Water":
                                if (money >= 0.7)
                                {
                                    money -= 0.7;
                                    Console.WriteLine("Purchased water");
                                }
                                else
                                {
                                    Console.WriteLine("Sorry, not enough money");
                                }
                                break;

                            case "Crisps":
                                if (money >= 1.5)
                                {
                                    money -= 1.5;
                                    Console.WriteLine("Purchased crisps");
                                }
                                else
                                {
                                    Console.WriteLine("Sorry, not enough money");
                                }
                                break;

                            case "Soda":
                                if (money >= 0.8)
                                {
                                    money -= 0.8;
                                    Console.WriteLine("Purchased soda");
                                }
                                else
                                {
                                    Console.WriteLine("Sorry, not enough money");
                                }
                                break;

                            case "Coke":
                                if (money >= 1)
                                {
                                    money -= 1;
                                    Console.WriteLine("Purchased coke");
                                }
                                else
                                {
                                    Console.WriteLine("Sorry, not enough money");
                                }
                                break;

                            default:
                                Console.WriteLine("Invalid product");
                                break;
                        }
                        product = Console.ReadLine();
                    }
                    break;
                }

                if (command == "0.1")
                {
                    money += 0.1;
                }
                else if (command == "0.2")
                {
                    money += 0.2;
                }
                else if (command == "0.5")
                {
                    money += 0.5;
                }
                else if (command == "1")
                {
                    money += Convert.ToDouble(command);
                }
                else if (command == "2")
                {
                    money += Convert.ToDouble(command);
                }
                else
                {
                    Console.WriteLine($"Cannot accept {command}");
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"Change: {money:f2}");
        }
    }
}
