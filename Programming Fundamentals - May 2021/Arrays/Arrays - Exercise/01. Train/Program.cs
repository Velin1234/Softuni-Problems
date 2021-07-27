using System;

namespace _01._Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int wagons = int.Parse(Console.ReadLine());
            int sum = 0;
            int[] wagonsPassangers = new int[wagons];
            for (int i = 0; i < wagons; i++)
            {
                int passangers = int.Parse(Console.ReadLine());
                sum += passangers;
                wagonsPassangers[i] = passangers;
            }
            Console.WriteLine(string.Join(" ",wagonsPassangers));
            Console.WriteLine(sum);
        }
    }
}
