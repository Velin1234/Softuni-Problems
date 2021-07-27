using System;

namespace _12.Trade_Commissions
{
    class Program
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine();
            double sales = double.Parse(Console.ReadLine());

            switch (town)
            {
                case "Sofia":
                    
                    if (sales >= 0 && sales <= 500)
                    {
                        sales = sales * 0.05;
                        Console.WriteLine($"{sales:f2}");
                    }
                    else if (sales > 500 && sales <= 1000) 
                    {
                        sales = sales * 0.07;
                        Console.WriteLine($"{sales:f2}");
                    }
                    else if (sales > 1000 && sales <= 10000)
                    {
                        sales = sales * 0.08;
                        Console.WriteLine($"{sales:f2}");
                    }
                    else if (sales > 1000)
                    {
                        sales = sales * 0.12;
                        Console.WriteLine($"{sales:f2}");
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }

                    break;
                
                case "Varna":
                    
                    if (sales >= 0 && sales <= 500)
                    {
                        sales = sales * 0.045;
                        Console.WriteLine($"{sales:f2}");
                    }
                    else if (sales > 500 && sales <= 1000)
                    {
                        sales = sales * 0.075;
                        Console.WriteLine($"{sales:f2}");
                    }
                    else if (sales > 1000 && sales <= 10000)
                    {
                        sales = sales * 0.1;
                        Console.WriteLine($"{sales:f2}");
                    }
                    else if (sales > 1000)
                    {
                        sales = sales * 0.13;
                        Console.WriteLine($"{sales:f2}");
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }

                    break;
                
                case "Plovdiv":

                    if (sales >= 0 && sales <= 500)
                    {
                        sales = sales * 0.055;
                        Console.WriteLine($"{sales:f2}");
                    }
                    else if (sales > 500 && sales <= 1000)
                    {
                        sales = sales * 0.08;
                        Console.WriteLine($"{sales:f2}");
                    }
                    else if (sales > 1000 && sales <= 10000)
                    {
                        sales = sales * 0.12;
                        Console.WriteLine($"{sales:f2}");
                    }
                    else if (sales > 1000)
                    {
                        sales = sales * 0.145;
                        Console.WriteLine($"{sales:f2}");
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }

                    break;
                
                default:
                    Console.WriteLine("error");
                    break;

            }
        }
    }
}
