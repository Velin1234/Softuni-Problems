using System;

namespace Fixing_Vol2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber,secondNumber;
            byte result;

            firstNumber = 30;
            secondNumber = 40;
            try
            {
                result = Convert.ToByte(firstNumber * secondNumber);
                Console.WriteLine($"{firstNumber} x {secondNumber} = {result}");
                Console.ReadLine();
            }
            catch (OverflowException oe)
            {
                Console.WriteLine(oe.Message);
            }
        }
    }
}
