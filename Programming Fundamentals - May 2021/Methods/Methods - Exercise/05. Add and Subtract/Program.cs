using System;

namespace _05._Add_and_Subtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            AddAndSubstract(n1, n2, n3);
        }

        private static void AddAndSubstract(int n1, int n2, int n3)
        {
            int sum = n1 + n2;
            int result = sum - n3;
            Console.WriteLine(result);
        }
    }
}
