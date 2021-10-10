using System;
using System.Collections.Generic;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>(); 
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] carInfo = Console.ReadLine().Split(" ");
                string carName = carInfo[0];
                double fuelAmount = Convert.ToDouble(carInfo[1]);
                double fuelConsumption = Convert.ToDouble(carInfo[2]);
                Car newCar = new Car(carName, fuelAmount, fuelConsumption);
                cars.Add(newCar);

            }
            string[] cmd = Console.ReadLine().Split(" ");
            while (cmd[0] != "End")
            {
                string carName = cmd[1];
                double distance = Convert.ToDouble(cmd[2]);
                foreach (var car in cars)
                {
                    if (car.Model == carName)
                    {
                        car.Drive(distance);
                    }
                }
                cmd = Console.ReadLine().Split(" ");
            }

            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.TravelledDistance}");
            }
        }
    }
}
