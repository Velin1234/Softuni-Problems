using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public abstract class Vehicle
    {
        private double fuelQuantity;
        private double litersPerKm;
        private double tankCapacity;

        public Vehicle(double fuelQuantity, double litersPerKm, double tankCapacity)
        {
            FuelQuantity = fuelQuantity;
            LitersPerKm = litersPerKm;
            TankCapacity = tankCapacity;
        }

        public double FuelQuantity { get => fuelQuantity; set => fuelQuantity = value; }
        public double LitersPerKm { get => litersPerKm; set => litersPerKm = value; }
        public double TankCapacity { get => tankCapacity; set => tankCapacity = value; }

        public abstract void Drive(double distance);
        public abstract void DriveEmpty(double distance);
        public abstract void Refuel(double liters);
        public abstract void CheckTank();
        public override string ToString()
        {
            return $"{this.GetType().Name}: {this.FuelQuantity:f2}";
        }
    }
}
