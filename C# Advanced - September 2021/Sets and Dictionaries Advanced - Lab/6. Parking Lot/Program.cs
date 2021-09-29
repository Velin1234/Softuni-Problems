using System;
using System.Collections.Generic;
using System.Linq;

namespace _6._Parking_Lot
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            HashSet<string> cars = new HashSet<string>();
            while (input[0] != "END")
            {
                switch (input[0])
                {
                    case "IN":
                        cars.Add(input[1]);
                        break;
                    case "OUT":
                        cars.Remove(input[1]);
                        break;
                }
                input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            }
      
            if (cars.Count != 0)
            {
                Console.WriteLine(string.Join("\n", cars));
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
        }
    }
}
