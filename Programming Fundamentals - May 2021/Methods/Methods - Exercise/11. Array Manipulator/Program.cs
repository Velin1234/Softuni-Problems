using System;
using System.Linq;

namespace _11._Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            string[] command = Console.ReadLine().Split(' ');
            while (command[0] != "end")
            {
                switch (command[0])
                {
                    case "max":
                        break;
                }
            }
        }
    }
}
