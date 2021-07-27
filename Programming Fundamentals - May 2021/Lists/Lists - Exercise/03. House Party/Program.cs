using System;
using System.Collections.Generic;

namespace _03._House_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> guests = new List<string>();

            for (int i = 1; i <= n; i++)
            {
                string[] guestController = Console.ReadLine().Split(" ");

                if (!guests.Contains(guestController[0]) && guestController[2] == "not")
                {
                    Console.WriteLine($"{guestController[0]} is not in the list!");
                }
                else if (guests.Contains(guestController[0]) && guestController[2] == "going!")
                {
                    Console.WriteLine($"{guestController[0]} is already in the list!");
                }
                else if (!guests.Contains(guestController[0]) && guestController[2] == "going!")
                {
                    guests.Add(guestController[0]);
                }
                else if (guests.Contains(guestController[0]) && guestController[2] == "not")
                {
                    for (int name = 0; name < guests.Count; name++)
                    {
                        if (guests[name] == guestController[0])
                        {
                            guests.Remove(guests[name]);
                        }
                    }
                }
            }
            Console.WriteLine(string.Join("\n",guests));
        }
    }
}
