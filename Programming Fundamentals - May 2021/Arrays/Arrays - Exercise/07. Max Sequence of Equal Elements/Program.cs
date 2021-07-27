using System;
using System.Linq;

namespace _07._Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int maxElements = 0;
            int currentEqualElements = 0;
            int element = 0;
            for (int i = 0; i < input.Length - 1; i++)
            {
                if (input[i] == input[i + 1])
                {
                    currentEqualElements++;
                }
                else
                {
                    currentEqualElements = 0;
                }

                if (currentEqualElements > maxElements)
                {
                    maxElements = currentEqualElements;
                    element = input[i];
                }
            }
            for (int i = 0; i < maxElements + 1; i++)
            {
                Console.Write(element +" ");
            }
        }
    }
}
