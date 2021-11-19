using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public class Car : Vehicle
    {
        public Car(double fuelQuantity, double litersPerKm,double tankCapacity) : base(fuelQuantity, litersPerKm,tankCapacity)
        {
        }

        public override void CheckTank()
        {
            if (this.FuelQuantity > this.TankCapacity)
            {
                this.FuelQuantity = 0;
            }
        }

        public override void Drive(double distance)
        {
            double usedLiters = distance * (this.LitersPerKm + 0.9);
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

        public override void DriveEmpty(double distance)
        {
            throw new NotImplementedException();
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
    }
}
