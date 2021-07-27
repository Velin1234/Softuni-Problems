using System;

namespace _06._Balanced_Brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool openedBracket = false;
            bool balanced = true;
            for (int i = 1; i <= n; i++)
            {
                string input = Console.ReadLine();


                if (input == "(")
                {
                    if (!openedBracket)
                    {
                        openedBracket = true;
                    }
                    else
                    {
                        balanced = false;
                    }
                }

                if (input == ")")
                {
                    if (openedBracket)
                    {
                        openedBracket = false;
                    }
                    else
                    {
                        balanced = false;
                    }
                }
            }

            if (balanced && !openedBracket)
            {
                Console.WriteLine("BALANCED");
            }
            else
            {
                Console.WriteLine("UNBALANCED");
            }
        }
    }
}
