using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm.Animals
{
    public class Cat : Feline
    {
        public Cat(string name, double weight, string livingRegion, string breed) : base(name, weight, livingRegion, breed)
        {
        }

        public override void Eat(Food.Food food)
        {
            if (ValidateFood(food.GetType().Name))
            {
                Weight += 0.3 * food.Quantity;
                FoodEaten += food.Quantity;
            }
        } 

        public override string Speak()
        {
            return "Meow";
        }
        private bool ValidateFood(string food)
        {
            if (food == "Vegetable" || food == "Meat")
            {
                return true;
            }
            throw new InvalidOperationException($"{GetType().Name} does not eat {food}!");
        }
    }
}
