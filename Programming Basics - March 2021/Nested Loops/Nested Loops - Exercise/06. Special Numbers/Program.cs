using System;

namespace _06._Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int num1 = 1111; num1 <= 9999; num1++)
            {
                int lastNum = num1 % 10;
                int secondLastNum = num1 % 100 / 10;
                int secondNum = num1 % 1000 / 100;
                int firstNum = num1 % 10000 / 1000;
                if (firstNum == 0 || secondNum == 0 || secondLastNum == 0 || lastNum == 0)
                {

                }
                else
                {
                    if (n % firstNum == 0 && n % secondNum == 0 && n % secondLastNum == 0 && n % lastNum == 0)
                    {
                        Console.Write(num1 +" ");
                    }
                }
            }
        }
    }
}
