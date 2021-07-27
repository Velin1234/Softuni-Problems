using System;
using System.Linq;

namespace _02._Shoot_for_the_Win
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] targets = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            string indecies = Console.ReadLine();
            int shotTargets = 0;

            while (indecies != "End")
            {
                try
                {
                    int oldTarget = targets[Convert.ToInt32(indecies)];

                    for (int i = 0; i < targets.Length; i++)
                    {
                        if (targets[i] > oldTarget && targets[i] != -1)
                        {
                            targets[i] -= oldTarget;
                        }
                        else if (targets[i] < oldTarget && targets[i] != -1)
                        {
                            targets[i] += oldTarget;
                        }
                        else if (targets[i]== oldTarget && targets[i] != -1)
                        {
                            targets[i] += oldTarget;
                        }
                    }

                    targets[Convert.ToInt32(indecies)] = -1;
                    shotTargets++;
                }
                catch
                {
                    
                }
                indecies = Console.ReadLine();
            }

            Console.WriteLine($"Shot targets: {shotTargets} -> {string.Join(" ", targets)}");

        }
    }
}
