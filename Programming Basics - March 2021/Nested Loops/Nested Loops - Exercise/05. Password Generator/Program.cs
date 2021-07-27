using System;

namespace _05._Password_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int L = int.Parse(Console.ReadLine());
            for (int num1 = 1; num1 < n; num1++)
            {
                for (int num2 = 1; num2 < n; num2++)
                {
                    for (int char1 = 'a'; char1 < 'a'+L; char1++)
                    {
                        for (int char2 = 'a'; char2 < 'a'+L; char2++)
                        {
                            for (int lastNum = 2; lastNum <= n; lastNum++)
                            {
                                if (lastNum > num1 && lastNum > num2)
                                {
                                    Console.Write($"{num1}{num2}{(char)char1}{(char)char2}{lastNum} ");
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}