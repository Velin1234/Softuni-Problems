using System;

namespace _2._Bit_at_Position_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            if (n==1)
            {
                Console.WriteLine(1);
                return;
            }
            string binary = Convert.ToString(n, 2);
            string last =Convert.ToString(binary[binary.Length - 2]);
            Console.WriteLine(last);
        }
    }
}
