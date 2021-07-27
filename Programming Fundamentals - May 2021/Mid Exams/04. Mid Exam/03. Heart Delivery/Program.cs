using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Heart_Delivery
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> neighborhood = Console.ReadLine().Split('@').Select(int.Parse).ToList();
            string[] actions = Console.ReadLine().Split(" ");
            int lastPos = 0;

            while (actions[0] != "Love!")
            {
                if (actions[0] == "Jump")
                {
                    lastPos += Convert.ToInt32(actions[1]);
                    if (lastPos > neighborhood.Count - 1)
                    {
                        lastPos = 0;
                    }
                    if (neighborhood[lastPos] == 0)
                    {
                        Console.WriteLine($"Place {lastPos} already had Valentine's day.");
                    }
                    else
                    {
                        neighborhood[lastPos] -= 2;
                        if (neighborhood[lastPos] == 0)
                        {
                            Console.WriteLine($"Place {lastPos} has Valentine's day.");
                        }
                    }
                }
                actions = Console.ReadLine().Split(" ");
            }

            Console.WriteLine($"Cupid's last position was {lastPos}.");
            int valentines = 0;
            for (int i = 0; i < neighborhood.Count; i++)
            {
                if (neighborhood[i] == 0)
                {
                    valentines++;
                }
            }

            if (valentines == neighborhood.Count)
            {
                Console.WriteLine("Mission was successful.");
            }
            else
            {
                int failedPlaces = neighborhood.Count - valentines;
                Console.WriteLine($"Cupid has failed {failedPlaces} places.");
            }
        }
    }
}
