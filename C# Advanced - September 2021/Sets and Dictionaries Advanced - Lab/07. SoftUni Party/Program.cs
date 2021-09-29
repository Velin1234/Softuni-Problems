using System;
using System.Collections.Generic;

namespace _07._SoftUni_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            string guest = Console.ReadLine();
            bool partyStart = false;
            HashSet<string> vips = new HashSet<string>();
            HashSet<string> guests = new HashSet<string>();
            while (guest != "END")
            {
                if (guest == "PARTY")
                {
                    partyStart = true;
                }
                if (partyStart)
                {
                    vips.Remove(guest);
                    guests.Remove(guest);
                }
                else
                {
                    if (char.IsDigit(guest[0]))
                    {
                        vips.Add(guest);
                    }
                    else
                    {
                        guests.Add(guest);
                    }
                }

                guest = Console.ReadLine();
            }

            Console.WriteLine(vips.Count + guests.Count);
            foreach (var g in vips)
            {
                Console.WriteLine(g);
            }
            foreach (var g in guests)
            {
                Console.WriteLine(g);
            }
        }
    }
}
