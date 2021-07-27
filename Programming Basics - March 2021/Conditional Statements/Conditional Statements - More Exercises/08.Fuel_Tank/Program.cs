using System;

namespace _08.Fuel_Tank
{
    class Program
    {
        static void Main(string[] args)
        {
            string type_of_fuel = Console.ReadLine();
            double liters_fuel = double.Parse(Console.ReadLine());
                                                
            if (type_of_fuel == "Diesel" || type_of_fuel =="Gasoline" || type_of_fuel=="Gas")
            {
                
                if (liters_fuel >= 25)
                {
                    Console.WriteLine($"You have enough {type_of_fuel.ToLower()}.");
                }
                else
                {
                    Console.WriteLine($"Fill your tank with {type_of_fuel.ToLower()}!");
                }
            }
            else
            {
                Console.WriteLine("Invalid fuel!");
            }            
        }
    }
}
