using System;

namespace _06._Unique_PIN_Codes
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            bool flag = true;

            for (int number1 = 1; number1 <= num1; number1++)
            {
                for (int number2 = 1; number2 <= num2; number2++)
                {
                    for (int number3 = 1; number3 <= num3; number3++)
                    {
                        if (number1 % 2 == 0)
                        {
                            flag = true;
                            if (number2 == 1)
                            {
                                flag = false;
                            }
                            else
                            {
                                for (int count = 2; count <= 7; count++)
                                {
                                    if (number2 % count == 0 && count != number2)
                                    {
                                        flag = false;
                                    }
                                }
                            }

                            if (flag)
                            {
                                if (number3 % 2 == 0)
                                {
                                    Console.WriteLine($"{number1} {number2} {number3}");
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}

