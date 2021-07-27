using System;

namespace _1._Binary_Digits_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            string binary = Convert.ToString(n, 2);
            int sum = 0;

            for (int i = 0; i < binary.Length; i++)
            {
                if (Convert.ToString(binary[i]) == Convert.ToString(b))
                {
                    sum++;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
