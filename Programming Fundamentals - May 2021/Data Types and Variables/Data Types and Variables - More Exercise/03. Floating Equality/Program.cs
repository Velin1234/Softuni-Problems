using System;

namespace _03._Floating_Equality
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal n1 = decimal.Parse(Console.ReadLine());
            decimal n2 = decimal.Parse(Console.ReadLine());
            bool Equal = false;
            decimal eps = 0.000001M;

            decimal numberEps = Math.Abs(n1 - n2);
            if (numberEps < eps)
            {
                Equal = true;
                Console.WriteLine(Equal);
            }
            else
            {
                Console.WriteLine(Equal);
            }
        }
    }
}
