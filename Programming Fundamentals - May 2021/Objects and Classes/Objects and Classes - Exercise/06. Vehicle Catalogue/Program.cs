using System;
using System.Collections.Generic;

namespace _06._Vehicle_Catalogue
{
    class Vechicle
    {
        public Vechicle(string type, string model, string color, double horsePower)
        {
            Type = type;
            Model = model;
            Color = color;
            HorsePower = horsePower;
        }

        public string Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public double HorsePower { get; set; }

        public override string ToString()
        {
            string vechicleStr = $"Type: {Type}\n" +
                $"Model: {Model}\n" +
                $"Color: {Color}\n" +
                $"Horsepower: {HorsePower}";
            return vechicleStr;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ");
            double averageCarHP = 0;
            double averageTruckHP = 0;
            List<Vechicle> vechicles = new List<Vechicle>();
            int cars = 0;
            int trucks = 0;

            while (input[0] != "End")
            {
                switch (input[0])
                {
                    case "car":
                        input[0] = "Car";
                        cars++;
                        averageCarHP += Convert.ToInt32(input[3]);
                        break;
                    case "truck":
                        input[0] = "Truck";
                        trucks++;
                        averageTruckHP += Convert.ToInt32(input[3]);
                        break;
                }
                Vechicle vechicle = new Vechicle(input[0], input[1], input[2], Convert.ToInt32(input[3]));
                vechicles.Add(vechicle);
                input = Console.ReadLine().Split(" ");
            }


            string[] catalogue = Console.ReadLine().Split("");
            while (catalogue[0] != "Close the Catalogue")
            {
                foreach (Vechicle vechicle in vechicles)
                {
                    if (catalogue[0] == vechicle.Model)
                    {
                        Console.WriteLine(vechicle.ToString());
                    }
                }
                catalogue = Console.ReadLine().Split("");
            }
            
            averageCarHP /= cars;
            averageTruckHP /= trucks;
            if (Double.IsNaN(averageCarHP))
            {
                averageCarHP = 0;
            }
            else if (Double.IsNaN(averageTruckHP))
            {
                averageTruckHP = 0;
            }
            Console.WriteLine($"Cars have average horsepower of: {averageCarHP:f2}.");
            Console.WriteLine($"Trucks have average horsepower of: {averageTruckHP:f2}.");
        }
    }
}
