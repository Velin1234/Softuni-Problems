using System;

namespace _02._Print_Numbers_in_Reverse_Order
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arrNums = new int[n];
            for (int i = arrNums.Length - 1; i >= 0; i--)
            {
                arrNums[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(string.Join(" ",arrNums));
        }
    }
}
