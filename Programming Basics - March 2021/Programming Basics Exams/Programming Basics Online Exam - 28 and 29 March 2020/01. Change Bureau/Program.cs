using System;

namespace _01._Change_Bureau
{
    class Program
    {
        static void Main(string[] args)
        {
            double bitcointToLev = 1168;
            double chineseYoanToDollar = 0.15;
            double dolarToLev = 1.76;
            double euroToLev = 1.95;

            int bitcoins = int.Parse(Console.ReadLine());
            double chineseYoan = double.Parse(Console.ReadLine());
            double commision = double.Parse(Console.ReadLine());

            
            double euro = (bitcoins * bitcointToLev + (chineseYoan * chineseYoanToDollar) * dolarToLev) / euroToLev;
            euro -= euro * commision / 100;
            Console.WriteLine($"{euro:f2}");
        }
    }
}
