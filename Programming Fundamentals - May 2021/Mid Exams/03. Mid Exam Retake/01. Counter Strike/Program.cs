using System;

namespace _01._Counter_Strike
{
    class Program
    {
        static void Main(string[] args)
        {
            int initEnergy = int.Parse(Console.ReadLine());
            string usedEnergy = Console.ReadLine();
            int wonBattles = 0;

            while (usedEnergy != "End of battle")
            {
                if (initEnergy >= Convert.ToInt32(usedEnergy))
                {
                    initEnergy -= Convert.ToInt32(usedEnergy);
                    wonBattles++;
                    if (wonBattles % 3 == 0)
                    {
                        initEnergy += wonBattles;
                    }
                }
                else
                {
                    Console.WriteLine($"Not enough energy! Game ends with {wonBattles} won battles and {initEnergy} energy");
                    return;
                }
                usedEnergy = Console.ReadLine();
            }

            Console.WriteLine($"Won battles: {wonBattles}. Energy left: {initEnergy}");
        }
    }
}
