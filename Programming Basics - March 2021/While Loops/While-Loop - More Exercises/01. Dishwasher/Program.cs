using System;

namespace _01._Dishwasher
{
    class Program
    {
        static void Main(string[] args)
        {
            int detergentBottles = int.Parse(Console.ReadLine());
            int detergent = detergentBottles * 750;
            int usedDetergent = 0;
            int counter = 0;
            int washedPots = 0;
            int washedDishes = 0;

            while (true)
            {
                var command = Console.ReadLine();
                if (command == "End")
                {
                    break;
                }
                else
                {
                    counter++;
                    if (counter % 3 == 0)
                    {
                        usedDetergent += Convert.ToInt32(command) * 15;
                        washedPots += Convert.ToInt32(command);
                    }
                    else
                    {
                        usedDetergent += Convert.ToInt32(command) * 5;
                        washedDishes += Convert.ToInt32(command);
                    }
                    
                    if (usedDetergent > detergent)
                    {
                        break;
                    }
                }
            }

            if (detergent >= usedDetergent)
            {
                int leftover =Math.Abs(detergent - usedDetergent);
                Console.WriteLine("Detergent was enough!");
                Console.WriteLine($"{washedDishes} dishes and {washedPots} pots were washed.");
                Console.WriteLine($"Leftover detergent {leftover} ml.");
            }
            else
            {
                int needed = Math.Abs(usedDetergent - detergent); 
                Console.WriteLine($"Not enough detergent, {needed} ml. more necessary!");
            }
        }
    }
}
