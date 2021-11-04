using System;

namespace Survivor
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int collectedTokens = 0;
            int opponentTokens = 0;
            string[][] seashells = new string[rows][];
            for (int i = 0; i < rows; i++)
            {
                seashells[i] = Console.ReadLine().Split();
            }

            string[] cmd = Console.ReadLine().Split();
            while (cmd[0] != "Gong")
            {
                switch (cmd[0])
                {
                    case "Find":
                        int row = int.Parse(cmd[1]);
                        int col = int.Parse(cmd[2]);
                        try
                        {
                            if (seashells[row][col] == "T")
                            {
                                collectedTokens++;
                                seashells[row][col] = "-";
                            }
                        }
                        catch
                        {

                        }
                        break;

                    case "Opponent":
                        row = int.Parse(cmd[1]);
                        col = int.Parse(cmd[2]);
                        string direction = cmd[3];
                        try
                        {
                            if (seashells[row][col] == "T")
                            {
                                opponentTokens++;
                                seashells[row][col] = "-";
                            }

                            switch (direction)
                            {
                                case "up":
                                    for (int i = 1; i <= 3; i++)
                                    {
                                        if (seashells[row - i][col] == "T")
                                        {
                                            opponentTokens++;
                                            seashells[row - i][col] = "-";
                                        }
                                    }
                                    break;
                                case "down":
                                    for (int i = 1; i <= 3; i++)
                                    {
                                        if (seashells[row + i][col] == "T")
                                        {
                                            opponentTokens++;
                                            seashells[row + i][col] = "-";
                                        }
                                    }
                                    break;
                                case "right":
                                    for (int i = 1; i <= 3; i++)
                                    {
                                        if (seashells[row][col + i] == "T")
                                        {
                                            opponentTokens++;
                                            seashells[row][col + i] = "-";
                                        }
                                    }
                                    break;
                                case "left":
                                    for (int i = 1; i <= 3; i++)
                                    {
                                        if (seashells[row][col - i] == "T")
                                        {
                                            opponentTokens++;
                                            seashells[row][col - i] = "-";
                                        }
                                    }
                                    break;
                            }
                        }
                        catch
                        {

                        }
                        break;
                    default:
                        break;
                }
                cmd = Console.ReadLine().Split();
            }

            foreach (var row in seashells)
            {
                Console.WriteLine(string.Join(" ", row));
            }
            Console.WriteLine($"Collected tokens: {collectedTokens}");
            Console.WriteLine($"Opponent's tokens: {opponentTokens}");

        }
    }
}
