using System;

namespace _04._Balls
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            int redBalls = 0;
            int orangeBalls = 0;
            int yellowBalls = 0;
            int whiteBalls = 0;
            int blackBalls = 0;
            int otherBalls = 0;
            
            int totalPoints = 0;
           
            for (int i = 1; i <= n; i++)
            {
                string color = Console.ReadLine();
                switch (color)
                {
                    case "red":
                        totalPoints += 5;
                        redBalls++;
                        break;

                    case "orange":
                        totalPoints += 10;
                        orangeBalls++;
                        break;

                    case "yellow":
                        totalPoints += 15;
                        yellowBalls++;
                        break;

                    case "white":
                        totalPoints += 20;
                        whiteBalls++;
                        break;
                    
                    case "black":
                        totalPoints /= 2;
                        blackBalls++;
                        break;

                    default:
                        otherBalls++;
                        break;
                }
            }

            Console.WriteLine($"Total points: {totalPoints}");
            Console.WriteLine($"Points from red balls: {redBalls}");
            Console.WriteLine($"Points from orange balls: {orangeBalls}");
            Console.WriteLine($"Points from yellow balls: {yellowBalls}");
            Console.WriteLine($"Points from white balls: {whiteBalls}");
            Console.WriteLine($"Other colors picked: {otherBalls}");
            Console.WriteLine($"Divides from black balls: {blackBalls}");

        }
    }
}
