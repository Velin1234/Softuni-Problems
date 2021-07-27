using System;

namespace _05.Account_Balance
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            decimal total = 0;
            while (input != "NoMoreMoney")
            {
                if (Convert.ToDecimal(input) < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                else
                {
                    total += Convert.ToDecimal(input);
                    Console.WriteLine($"Increase: {Convert.ToDecimal(input):f2}");
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"Total: {total:f2}");
        }
    }
}
