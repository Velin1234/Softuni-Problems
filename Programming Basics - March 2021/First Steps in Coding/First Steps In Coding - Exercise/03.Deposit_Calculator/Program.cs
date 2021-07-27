using System;

namespace _03.Deposit_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double deposited_amount = double.Parse(Console.ReadLine());
            int months_to_repay = int.Parse(Console.ReadLine());
            double yearly_percentage = double.Parse(Console.ReadLine());
            double amount = deposited_amount + months_to_repay * (((deposited_amount/100) * yearly_percentage)/12);
            Console.WriteLine($"{amount:f2}");
        }
    }
}
