using System;

namespace _05._Average_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double sum = 0;
            for (int i = 1; i <= n; i++)
            {
                double number = int.Parse(Console.ReadLine());
                sum += number;
            }
            double avg = sum / n;
            Console.WriteLine($"{avg:f2}");
        }
    }
}
