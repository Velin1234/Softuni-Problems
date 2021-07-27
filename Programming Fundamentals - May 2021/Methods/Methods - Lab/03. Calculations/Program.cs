using System;

namespace _03._Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int result = 0;
            switch (command)
            {
                case "add":
                    result = Add(a, b);
                    break;
                case "multiply":
                    result = Multiply(a, b);
                    break;
                case "substract":
                    result = Substract(a, b);
                    break;
                case "divide":
                    result = Divide(a, b);
                    break;
            }
            Console.WriteLine(result);
        }

        static int Divide(int a, int b)
        {
            return a / b;
        }

        static int Substract(int a, int b)
        {
            return a - b;
        }

        static int Multiply(int a, int b)
        {
            return a * b;
        }

        static int Add(int a, int b)
        {
            return a + b;
        }
    }
}
