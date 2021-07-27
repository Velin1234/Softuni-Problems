using System;

namespace _3.SumOfNums
{
    class Program
    {
        static void Main(string[] args)
        {
            int neededNumber = int.Parse(Console.ReadLine());
            int result = 0;
            while (result < neededNumber && result != neededNumber)
            {
                int number = int.Parse(Console.ReadLine());
                result += number;
            }
            Console.WriteLine(result);
        }
    }
}
