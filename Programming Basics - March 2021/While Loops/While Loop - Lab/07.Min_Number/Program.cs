using System;

namespace _07.Min_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            int minNum = int.MaxValue;
            while (true)
            {
                if (input == "Stop")
                {
                    break;
                }
                if (Convert.ToInt32(input) < minNum)
                {
                    minNum = Convert.ToInt32(input);
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(minNum);
        }
    }
}
