using System;

namespace _03.New_House
{
    class Program
    {
        static void Main(string[] args)
        {
            const double roses_price = 5;
            const double dahlia_price = 3.8;
            const double tulip_price = 2.8;
            const double narcis_price = 3;
            const double gladiolus_price = 2.5;

            string type_of_flowers = Console.ReadLine();
            int amount_of_flowers = int.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());

            double roses_for_garden = amount_of_flowers * roses_price;
            double dahlias_for_garden = amount_of_flowers * dahlia_price;
            double tulips_for_garden = amount_of_flowers * tulip_price;
            double narcissus_for_garden = amount_of_flowers * narcis_price;
            double gladious_for_garden = amount_of_flowers * gladiolus_price;

            switch (type_of_flowers) 
            {
                case "Roses":
                    if (amount_of_flowers > 80)
                    {
                        roses_for_garden -= roses_for_garden * 0.1;
                        if (roses_for_garden <= budget)
                        {
                            roses_for_garden -= budget;
                            Console.WriteLine($"Hey, you have a great garden with {amount_of_flowers} Roses and {Math.Abs(roses_for_garden):f2} leva left.");
                        }
                        else
                        {
                            budget -= roses_for_garden;
                            Console.WriteLine($"Not enough money, you need {Math.Abs(budget):f2} leva more.");
                        }
                    }
                    else
                    {
                        if (roses_for_garden <= budget)
                        {
                            roses_for_garden -= budget;
                            Console.WriteLine($"Hey, you have a great garden with {amount_of_flowers} Roses and {Math.Abs(roses_for_garden):f2} leva left.");
                        }
                        else
                        {
                            budget -= roses_for_garden;
                            Console.WriteLine($"Not enough money, you need {Math.Abs(budget):f2} leva more.");
                        }
                    }
                    break;

                case "Dahlias":
                        if (amount_of_flowers > 90)
                        {
                            dahlias_for_garden -= dahlias_for_garden * 0.15;
                            if (dahlias_for_garden <= budget)
                            {
                                dahlias_for_garden -= budget;
                                Console.WriteLine($"Hey, you have a great garden with {amount_of_flowers} Dahlias and {Math.Abs(dahlias_for_garden):f2} leva left.");
                            }
                            else
                            {
                                budget -= dahlias_for_garden;
                                Console.WriteLine($"Not enough money, you need {Math.Abs(budget):f2} leva more.");
                            }
                        }
                        else
                        {
                            if (dahlias_for_garden <= budget)
                            {
                                dahlias_for_garden -= budget;
                                Console.WriteLine($"Hey, you have a great garden with {amount_of_flowers} Dahlias and {Math.Abs(dahlias_for_garden):f2} leva left.");
                            }
                            else
                            {
                                budget -= dahlias_for_garden;
                                Console.WriteLine($"Not enough money, you need {Math.Abs(budget):f2} leva more.");
                            }
                        }
                    break;

                case "Tulips":
                    if (amount_of_flowers > 80)
                    {
                        tulips_for_garden -= tulips_for_garden * 0.15;
                        if (tulips_for_garden <= budget)
                        {
                            tulips_for_garden -= budget;
                            Console.WriteLine($"Hey, you have a great garden with {amount_of_flowers} Tulips and {Math.Abs(tulips_for_garden):f2} leva left.");
                        }
                        else
                        {
                            budget -= tulips_for_garden;
                            Console.WriteLine($"Not enough money, you need {Math.Abs(budget):f2} leva more.");
                        }
                    }
                    else
                    {
                        if (tulips_for_garden <= budget)
                        {
                            tulips_for_garden -= budget;
                            Console.WriteLine($"Hey, you have a great garden with {amount_of_flowers} Tulips and {Math.Abs(tulips_for_garden):f2} leva left.");
                        }
                        else
                        {
                            budget -= tulips_for_garden;
                            Console.WriteLine($"Not enough money, you need {Math.Abs(budget):f2} leva more.");
                        }
                    }
                    break;

                case "Narcissus":
                    if(amount_of_flowers < 120)
                    {
                        narcissus_for_garden += narcissus_for_garden * 0.15;
                        if (narcissus_for_garden <= budget)
                        {
                            narcissus_for_garden -= budget;
                            Console.WriteLine($"Hey, you have a great garden with {amount_of_flowers} Narcissus and {Math.Abs(narcissus_for_garden):f2} leva left.");
                        }
                        else
                        {
                            budget -= narcissus_for_garden;
                            Console.WriteLine($"Not enough money, you need {Math.Abs(budget):f2} leva more.");
                        }
                    }
                    else
                    {
                        if (narcissus_for_garden <= budget)
                        {
                            narcissus_for_garden -= budget;
                            Console.WriteLine($"Hey, you have a great garden with {amount_of_flowers} Narcissus and {Math.Abs(narcissus_for_garden):f2} leva left.");
                        }
                        else
                        {
                            budget -= narcissus_for_garden;
                            Console.WriteLine($"Not enough money, you need {Math.Abs(budget):f2} leva more.");
                        }
                    }
                    break;

                case "Gladiolus":
                    if (amount_of_flowers < 80)
                    {
                        gladious_for_garden += gladious_for_garden * 0.2;
                        if (gladious_for_garden <= budget)
                        {
                            gladious_for_garden -= budget;
                            Console.WriteLine($"Hey, you have a great garden with {amount_of_flowers} Gladiolus and {Math.Abs(gladious_for_garden):f2} leva left.");
                        }
                        else
                        {
                            budget -= gladious_for_garden;
                            Console.WriteLine($"Not enough money, you need {Math.Abs(budget):f2} leva more.");
                        }
                    }
                    else
                    {
                        if (gladious_for_garden <= budget)
                        {
                            gladious_for_garden -= budget;
                            Console.WriteLine($"Hey, you have a great garden with {amount_of_flowers} Gladiolus and {Math.Abs(gladious_for_garden):f2} leva left.");
                        }
                        else
                        {
                            budget -= gladious_for_garden;
                            Console.WriteLine($"Not enough money, you need {Math.Abs(budget):f2} leva more.");
                        }
                    }
                    break;
            }
        }
    }
}
