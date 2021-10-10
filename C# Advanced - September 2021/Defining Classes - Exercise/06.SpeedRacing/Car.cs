using System;
using System.Collections.Generic;
using System.Text;

namespace CarManufacturer
{
    public class Car
    {
        private string model;
        private double fuelAmount;
        private double fuelConsumptionPerKilometer;
        private double travelledDistance;

        public Car(string model, double fuelAmount, double fuelConsumptionPerKilometer)
        {
            Model = model;
            FuelAmount = fuelAmount;
            FuelConsumptionPerKilometer = fuelConsumptionPerKilometer;
            TravelledDistance = 0;
        }

        public string Model { get => model; set => model = value; }
        public double FuelAmount { get => fuelAmount; set => fuelAmount = value; }
        public double FuelConsumptionPerKilometer { get => fuelConsumptionPerKilometer; set => fuelConsumptionPerKilometer = value; }
        public double TravelledDistance { get => travelledDistance; set => travelledDistance = value; }

        public void Drive(double distance)
        {
            double usedFuel = distance * FuelConsumptionPerKilometer;
            if (FuelAmount >= usedFuel)
            {
                FuelAmount -= usedFuel;
                TravelledDistance += distance;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
        }
    }
}
