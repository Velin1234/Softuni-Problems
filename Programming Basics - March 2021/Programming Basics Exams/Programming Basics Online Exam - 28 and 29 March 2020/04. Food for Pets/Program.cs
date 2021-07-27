using System;

namespace _04._Food_for_Pets
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            double AvailableFood = double.Parse(Console.ReadLine());
            double biscuits = 0;
            double dogEatenFood = 0;
            double catEatenFood = 0;

            for (int day = 1; day <= days; day++)
            {
                int foodEatenDog = int.Parse(Console.ReadLine());
                dogEatenFood += foodEatenDog;
                int foodEatenCat = int.Parse(Console.ReadLine());
                catEatenFood += foodEatenCat;
                if (day % 3 == 0)
                {
                    biscuits += (foodEatenDog + foodEatenCat) * 0.1;
                }
            }
            double wholeEatenFood = (dogEatenFood + catEatenFood);
            double percentEatenFood = wholeEatenFood / AvailableFood * 100;
            double percentEatenFoodByDog = dogEatenFood / wholeEatenFood * 100;
            double percentEatenFoodByCat = catEatenFood / wholeEatenFood * 100;

            Console.WriteLine($"Total eaten biscuits: {Convert.ToInt32(biscuits)}gr.");
            Console.WriteLine($"{percentEatenFood:f2}% of the food has been eaten.");
            Console.WriteLine($"{percentEatenFoodByDog:f2}% eaten from the dog.");
            Console.WriteLine($"{percentEatenFoodByCat:f2}% eaten from the cat.");
        }
    }
}
