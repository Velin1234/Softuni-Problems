using System;

namespace _02._Pounds_to_Dollars
{
    class Program
    {
        static void Main(string[] args)
        {
            const decimal BPD_To_USD = 1.31M;
            decimal BPD = decimal.Parse(Console.ReadLine());
            decimal USD = BPD * BPD_To_USD;
            Console.WriteLine($"{USD:f3}");
        }
    }
}
    