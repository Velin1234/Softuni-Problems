using System;

namespace _08._Math_Power
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());
            double result = 0;
            result = RaisedToPower(num, power);
            Console.WriteLine(result);
        }

        private static double RaisedToPower(double num, int power)
        {
            return Math.Pow(num, power);
        }
    }
}
