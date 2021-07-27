using System;
using System.Linq;

namespace _02._The_Lift
{
    class Program
    {
        static void Main(string[] args)
        {
            int peopleOnLift = int.Parse(Console.ReadLine());
            int[] wagons = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            bool emptySpots = false;
            for (int i = 0; i < wagons.Length; i++)
            {
                if (wagons[i] < 4)
                {
                    while (wagons[i] != 4)
                    {
                        if (peopleOnLift == 0)
                        {
                            break;
                        }
                        wagons[i]++;
                        peopleOnLift--;
                    }
                }
            }

            for (int wagon = 0; wagon < wagons.Length; wagon++)
            {
                if (wagons[wagon] < 4)
                {
                    emptySpots = true;
                }
            }

            if (peopleOnLift > 0)
            {
                Console.WriteLine($"There isn't enough space! {peopleOnLift} people in a queue!");
            }

            if (emptySpots)
            {
                Console.WriteLine("The lift has empty spots!");
            }
            Console.WriteLine(string.Join(" ", wagons));

        }
    }
}
