using System;

namespace _05._Care_of_Puppy
{
    class Program
    {
        static void Main(string[] args)
        {
            int kgFood = int.Parse(Console.ReadLine());
            int gFood = kgFood * 1000;
            var input = Console.ReadLine();
            int foodEaten = 0;
            while (input != "Adopted")
            {
                foodEaten += Convert.ToInt32(input);
                input = Console.ReadLine();
            }
            if (foodEaten <= gFood)
            {
                Console.WriteLine($"Food is enough! Leftovers: {gFood-foodEaten} grams.");
            }
            else
            {
                Console.WriteLine($"Food is not enough. You need {foodEaten-gFood} grams more.");
            }
        }
    }
}
