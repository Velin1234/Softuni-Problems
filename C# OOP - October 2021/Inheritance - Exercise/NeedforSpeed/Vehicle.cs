using System;
using System.Collections.Generic;
using System.Text;

namespace NeedForSpeed
{
    public class Vehicle
    {
        private int horsePower;
        private double fuel;

        public Vehicle(int horsePower, double fuel)
        {
            HorsePower = horsePower;
            Fuel = fuel;
        }

        public int HorsePower { get => horsePower; set => horsePower = value; }
        public double Fuel { get => fuel; set => fuel = value; }
        public double DefaultFuelConsumption { get; set; } = 1.25;
        //public virtual double FuelConsumption { get; set; }


        public virtual void Drive(double kilometers)
        {
            if (this.Fuel > 0)
            {
                this.Fuel -= kilometers * DefaultFuelConsumption;
            }
            if (this.Fuel < 0)
            {
                this.Fuel = 0;
            }
        }
    }
}
