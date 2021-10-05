using System;

namespace _01._Action_Print
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string[]> printCollectioon = input => Console.WriteLine(string.Join(Environment.NewLine, input));
            string[] input = Console.ReadLine().Split();
            printCollectioon(input);
        }
    }
}