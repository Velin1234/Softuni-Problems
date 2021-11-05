using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public class Beverage : Product
    {
        private double mililiters;
        public Beverage(string name, decimal price, double mililiters) : base(name, price)
        {
            Mililiters = mililiters;
        }

        public double Mililiters { get => mililiters; set => mililiters = value; }
    }
}
