using System;

namespace _09.Fruit_or_Vegetable
{
    class Program
    {
        static void Main(string[] args)
        {
            string food = Console.ReadLine();
            food = food.ToLower();
            //Fruits
            if (food == "banana")
            {
                Console.WriteLine("fruit");
            }
            else if (food == "apple")
            {
                Console.WriteLine("fruit");
            }
            else if (food == "kiwi")
            {
                Console.WriteLine("fruit");
            }
            else if (food == "cherry")
            {
                Console.WriteLine("fruit");
            }
            else if (food == "lemon")
            {
                Console.WriteLine("fruit");
            }
            else if (food == "grapes")
            {
                Console.WriteLine("fruit");
            }
            //Vegetables
            else if (food == "tomato")
            {
                Console.WriteLine("vegetable");
            }
            else if (food == "cucumber")
            {
                Console.WriteLine("vegetable");
            }
            else if (food == "pepper")
            {
                Console.WriteLine("vegetable");
            }
            else if (food == "carrot")
            {
                Console.WriteLine("vegetable");
            }
            // Unknown
            else
            {
                Console.WriteLine("unknown");
            }
        }
    }
}
