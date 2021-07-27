using System;

namespace _02._MuOnline
{
    class Program
    {
        static void Main(string[] args)
        {
            int initHealth = 100;
            int initBitC = 0;
            string[] rooms = Console.ReadLine().Split('|');
            int room = 0;

            for (int i = 0; i < rooms.Length; i++)
            {
                room++;
                string[] actions = rooms[i].Split(" ");

                switch (actions[0])
                {
                    case "potion":
                        int oldHealth = initHealth;
                        initHealth += Convert.ToInt32(actions[1]);
                        if (initHealth > 100)
                        {
                            initHealth = 100;
                        }
                        Console.WriteLine($"You healed for {Math.Abs(initHealth - oldHealth)} hp.");
                        Console.WriteLine($"Current health: {initHealth} hp.");
                        break;

                    case "chest":
                        initBitC += Convert.ToInt32(actions[1]);
                        Console.WriteLine($"You found {Convert.ToInt32(actions[1])} bitcoins.");
                        break;

                    default:
                        initHealth -= Convert.ToInt32(actions[1]);
                        if (initHealth <= 0)
                        {
                            Console.WriteLine($"You died! Killed by {actions[0]}.");
                            Console.WriteLine($"Best room: {room}");
                            Environment.Exit(1);
                        }
                        Console.WriteLine($"You slayed {actions[0]}.");
                        break;
                }
            }

            Console.WriteLine($"You've made it!\n" + $"Bitcoins: {initBitC}\n" + $"Health: {initHealth}");
        }
    }
}
