using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm.Animals
{
    public class Owl : Bird
    {
        public Owl(string name, double weight, double wingSize) : base(name, weight, wingSize)
        {
        }
        public override string Speak()
        {
            return "Hoot Hoot";
        }
        public override void Eat(Food.Food food)
        {
            if (ValidateFood(food.GetType().Name))
            {
                Weight += 0.25 * food.Quantity;
                FoodEaten += food.Quantity;
            }
        }
        private bool ValidateFood(string food)
        {
            if (food == "Meat")
            {
                return true;
            }
            throw new InvalidOperationException($"{GetType().Name} does not eat {food}!");
        }
    }
}
