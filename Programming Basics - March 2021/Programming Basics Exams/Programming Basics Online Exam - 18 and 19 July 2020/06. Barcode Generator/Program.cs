using System;

namespace _06._Barcode_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int numero1 = firstNum % 10000 / 1000;
            int numero2 = firstNum % 1000 / 100;
            int numero3 = firstNum % 100 / 10;
            int numero4 = firstNum % 10;

            int secondNum = int.Parse(Console.ReadLine());
            int number1 = secondNum % 10000 / 1000;
            int number2 = secondNum % 1000 / 100;
            int number3 = secondNum % 100 / 10;
            int number4 = secondNum % 10;

            for (int num = firstNum; num <= secondNum; num++)
            {
                int num1 = num % 10000 / 1000;
                int num2 = num % 1000 / 100;
                int num3 = num % 100 / 10;
                int num4 = num % 10;
                if (num1 % 2 != 0 && num1 >= numero1 && num1 <= number1)
                {
                    if (num2 % 2 != 0 && num2 >= numero2 && num2 <= number2)
                    {
                        if (num3 % 2 != 0 && num3 >= numero3 && num3 <= number3)
                        {
                            if (num4 % 2 != 0 && num4 >= numero4 && num4 <= number4)
                            {
                                Console.Write($"{num1}{num2}{num3}{num4}"+" ");
                            }
                        }
                    }
                }
            }
        }
    }
}
