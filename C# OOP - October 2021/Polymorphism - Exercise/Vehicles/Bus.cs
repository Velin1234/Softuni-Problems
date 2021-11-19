using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public class Bus : Vehicle
    {
        public Bus(double fuelQuantity, double litersPerKm, double tankCapacity) : base(fuelQuantity, litersPerKm, tankCapacity)
        {
        }

        public override void Drive(double distance)
        {
            double usedLiters = distance * (this.LitersPerKm + 1.4);
            if (usedLiters > this.FuelQuantity)
            {
                Console.WriteLine($"{this.GetType().Name} needs refueling");
            }
            else
            {
                this.FuelQuantity -= usedLiters;
                Console.WriteLine($"{this.GetType().Name} travelled {distance} km");
            }
        }

        public override void Refuel(double liters)
        {
            if (liters < 1)
            {
                Console.WriteLine("Fuel must be a positive number");
                return;
            }
            double insertedLiters = this.FuelQuantity + liters;
            if (insertedLiters > TankCapacity)
            {
                Console.WriteLine($"Cannot fit {liters} fuel in the tank");
                return;
            }
            this.FuelQuantity = insertedLiters;
        }

        public override void DriveEmpty(double distance)
        {
            double usedLiters = distance * this.LitersPerKm;
            if (usedLiters > this.FuelQuantity)
            {
                Console.WriteLine($"{this.GetType().Name} needs refueling");
            }
            else
            {
                this.FuelQuantity -= usedLiters;
                Console.WriteLine($"{this.GetType().Name} travelled {distance} km");
            }
        }

        public override void CheckTank()
        {
            if (this.FuelQuantity > this.TankCapacity)
            {
                this.FuelQuantity = 0;
            }
        }
    }
}
