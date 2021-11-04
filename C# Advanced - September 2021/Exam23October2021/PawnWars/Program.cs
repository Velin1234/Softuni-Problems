using System;
using System.Collections.Generic;

namespace PawnWars
{
    class Program
    {
        static void Main(string[] args)
        {
            string[][] checkboard = new string[8][];
            for (int i = 0; i < 8; i++)
            {
                string row = Console.ReadLine();
                List<string> rowChars = new List<string>();
                foreach (var @char in row)
                {
                    rowChars.Add(@char.ToString());
                }
                checkboard[i] = rowChars.ToArray();
            }

            foreach (var row in checkboard)
            {
                int index = 0;
                foreach (var item in row)
                {
                    if (item =="w")
                    {
                        row[index]= "-";
                        checkboard[][index] = "w";
                    }
                    index++;
                }
                index = 0;
            }

            foreach (var row in checkboard)
            {
                Console.WriteLine(string.Join("", row));
            }
        }
    }
}
