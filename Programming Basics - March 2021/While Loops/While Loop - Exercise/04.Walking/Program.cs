using System;

namespace _04.Walking
{
    class Program
    {
        static void Main(string[] args)
        {
            const int stepsGoal = 10000;
            int walkedSteps = 0;
            bool reachedGoal = false;
            int moreSteps = 0;
            int leftSteps = 0;

            while (reachedGoal != true)
            {
                var steps = Console.ReadLine();
                
                if (steps == "Going home")
                {
                    int stepsToHome = int.Parse(Console.ReadLine());
                    walkedSteps += stepsToHome;
                    break;
                }
                
                walkedSteps += Convert.ToInt32(steps);
                
                if (walkedSteps >= stepsGoal)
                {
                    moreSteps = walkedSteps - stepsGoal;
                    reachedGoal = true;
                    break;
                }

            }
            if (walkedSteps < stepsGoal)
            {
                leftSteps = stepsGoal - walkedSteps;
                
            }
            if (walkedSteps >= stepsGoal)
            {
                moreSteps = walkedSteps - stepsGoal;
                reachedGoal = true;
            }

            if (reachedGoal)
            {
                Console.WriteLine("Goal reached! Good job!");
                Console.WriteLine($"{moreSteps} steps over the goal!");
            }
            else
            {
                Console.WriteLine($"{leftSteps} more steps to reach goal.");
            }
        }
    }
}

