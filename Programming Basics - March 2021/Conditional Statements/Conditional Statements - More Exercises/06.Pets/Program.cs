using System;

namespace _06.Pets
{
    class Program
    {
        static void Main(string[] args)
        {
            int number_of_days = int.Parse(Console.ReadLine());
            int left_food_in_kg = int.Parse(Console.ReadLine());
            double dog_food_in_kg = double.Parse(Console.ReadLine());
            double cat_food_in_kg = double.Parse(Console.ReadLine());
            double turtle_food_in_g = double.Parse(Console.ReadLine());

            double dog_food_eaten = number_of_days * dog_food_in_kg;
            double cat_food_eaten = number_of_days * cat_food_in_kg;
            double turtle_food_eaten = (number_of_days * turtle_food_in_g) / 1000;
            double whole_food_eaten = dog_food_eaten + cat_food_eaten + turtle_food_eaten;

            if (whole_food_eaten <= left_food_in_kg)
            {
                double left_food = Math.Floor(left_food_in_kg - whole_food_eaten);
                Console.WriteLine($"{left_food} kilos of food left.");
            }
            else
            {
                double needed_food = Math.Ceiling(whole_food_eaten - left_food_in_kg);
                Console.WriteLine($"{needed_food} more kilos of food are needed.");
            }
        }
    }
}
