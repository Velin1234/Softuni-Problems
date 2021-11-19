using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm.Animals
{
    public class Mouse : Mammal
    {
        public Mouse(string name, double weight, string livingRegion) : base(name, weight, livingRegion)
        {
        }

        public override void Eat(Food.Food food)
        {
            if (ValidateFood(food.GetType().Name))
            {
                Weight += 0.1 * food.Quantity;
                FoodEaten += food.Quantity;
            }
        }

        public override string Speak()
        {
            return "Squeak";
        }
        private bool ValidateFood(string food)
        {
            if (food == "Vegetable" || food == "Fruit")
            {
                return true;
            }
            throw new InvalidOperationException($"{GetType().Name} does not eat {food}!");
        }
    }
}
