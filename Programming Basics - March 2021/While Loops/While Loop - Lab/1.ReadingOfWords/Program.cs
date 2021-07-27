using System;

namespace _1.ReadingOfWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            while (true)
            {
                input = Console.ReadLine();
                if (input =="Stop")
                {
                    break;
                }
                Console.WriteLine(input);
            }
            
        }
    }
}
