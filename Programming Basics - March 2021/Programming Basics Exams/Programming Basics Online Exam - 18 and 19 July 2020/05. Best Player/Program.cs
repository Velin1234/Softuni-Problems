using System;

namespace _05._Best_Player
{
    class Program
    {
        static void Main(string[] args)
        {
            string bestPlayerName = "";
            int mostGoals = 0;
            while (true)
            {
                string name = Console.ReadLine();
                if (name == "END")
                {
                    break;
                }
                int goals = int.Parse(Console.ReadLine());
                if (goals > mostGoals)
                {
                    mostGoals = goals;
                    bestPlayerName = name;
                }
                if (goals >= 10)
                {
                    break;
                }
            }
            Console.WriteLine($"{bestPlayerName} is the best player!");
            if (mostGoals >= 3)
            {

                Console.WriteLine($"He has scored {mostGoals} goals and made a hat-trick !!!");
            }
            else
            {
                Console.WriteLine($"He has scored {mostGoals} goals.");
            }
        }
    }
}
