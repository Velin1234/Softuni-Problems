using System;

namespace _06.Max_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            int maxNum = int.MinValue;
            while (true)
            {
                if (input =="Stop")
                {
                    break;
                }
                if (Convert.ToInt32(input) > maxNum)
                {
                    maxNum = Convert.ToInt32(input);
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(maxNum);  
        }
    }
}
