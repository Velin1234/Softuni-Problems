using System;

namespace _09._Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            int widthMeters = int.Parse(Console.ReadLine());
            int lenghtMeters = int.Parse(Console.ReadLine());
            int heightMeters = int.Parse(Console.ReadLine());

            int placeCubicMeters = widthMeters * lenghtMeters * heightMeters;
            int boxesCubicMeters = 0;
            var input = Console.ReadLine();
            while (input != "Done")
            {
                boxesCubicMeters += Convert.ToInt32(input);
                if (placeCubicMeters < boxesCubicMeters)
                {
                    int neededCubicMeters = boxesCubicMeters - placeCubicMeters;
                    Console.WriteLine($"No more free space! You need {neededCubicMeters} Cubic meters more.");
                    Environment.Exit(0);
                }
                input = Console.ReadLine();                
            }

            if (placeCubicMeters >= boxesCubicMeters)
            {
                int leftCubicMeters = placeCubicMeters - boxesCubicMeters;
                Console.WriteLine($"{leftCubicMeters} Cubic meters left.");
            }

        }
    }
}
