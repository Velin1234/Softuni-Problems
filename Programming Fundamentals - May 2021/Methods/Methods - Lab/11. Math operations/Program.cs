using System;

namespace _11._Math_operations
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1 = double.Parse(Console.ReadLine());
            char @operator = Convert.ToChar(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine());
            double result = 0;
            result = Calulate(n1, @operator, n2, result);
            Console.WriteLine(result);

        }

        private static double Calulate(double n1, char @operator, double n2, double result)
        {
            switch (@operator)
            {
                case '+':
                    result = n1 + n2;
                    break;
                case '*':
                    result = n1 * n2;
                    break;
                case '-':
                    result = n1 - n2;
                    break;
                case '/':
                    result = n1 / n2;
                    break;
            }

            return result;
        }
    }
}
