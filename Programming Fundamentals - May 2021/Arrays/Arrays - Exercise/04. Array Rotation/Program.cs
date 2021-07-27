using System;
using System.Linq;

namespace _04._Array_Rotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            int rotation = int.Parse(Console.ReadLine());
            for (int rotate = 0; rotate < rotation ; rotate++)
            {
                var temp = numbers[0];
                for (var i = 0; i < numbers.Length - 1; i++)
                {
                    numbers[i] = numbers[i + 1];
                }
                numbers[numbers.Length - 1] = temp;

            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
