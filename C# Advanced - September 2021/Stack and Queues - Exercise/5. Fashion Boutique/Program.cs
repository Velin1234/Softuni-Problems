using System;
using System.Collections.Generic;
using System.Linq;

namespace _5._Fashion_Boutique
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> clothes = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));
            int clothePerRack = int.Parse(Console.ReadLine());
            int currentClothes = 0;
            int racks = 1;

            while (clothes.Count > 0)
            {
                if (currentClothes + clothes.Peek()>clothePerRack)
                {
                    currentClothes = 0;
                    racks++;
                }
                currentClothes += clothes.Pop();
            }
            Console.WriteLine(racks);
        }
    }
}
