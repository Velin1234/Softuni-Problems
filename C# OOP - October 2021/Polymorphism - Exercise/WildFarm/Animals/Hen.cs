using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm.Animals
{
    public class Hen : Bird
    {
        public Hen(string name, double weight, double wingSize) : base(name, weight, wingSize)
        {
        }
        public override string Speak()
        {
            return "Cluck";
        }
        public override void Eat(Food.Food food)
        {
            this.Weight += food.Quantity * 0.35;
            this.FoodEaten += food.Quantity;
        }
    }
}
