using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace BirthdayCelebration
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> guestEntry = new Queue<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
            Stack<int> plates = new Stack<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
            int wastedFood = 0;
            int currentGuestPlate = guestEntry.Peek();

            while (true)
            {
                if (plates.Count == 0 || guestEntry.Count == 0)
                {
                    break;
                }

                if (currentGuestPlate <= plates.Peek())
                {
                    wastedFood += plates.Peek() - currentGuestPlate;
                    guestEntry.Dequeue();
                    plates.Pop();
                    if (plates.Count == 0 || guestEntry.Count == 0)
                    {
                        break;
                    }
                    currentGuestPlate = guestEntry.Peek();
                }
                else
                {
                    currentGuestPlate -= plates.Peek();
                    plates.Pop();
                }

            }

            if (guestEntry.Count == 0 && plates.Count > 0)
            {
                Console.WriteLine($"Plates: {string.Join(" ", plates)}");
            }
            else if (guestEntry.Count > 0 && plates.Count == 0)
            {
                Console.WriteLine($"Guests: {string.Join(" ", guestEntry)}");
            }
            Console.WriteLine($"Wasted grams of food: {wastedFood}");

        }
    }
}
