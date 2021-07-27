using System;

namespace _06._Triples_of_Latin_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int char1 = 0; char1 < n; char1++)
            {
                char firstChar = (char)('a' + char1);
                for (int char2 = 0; char2 < n; char2++)
                {
                    char secondChar = (char)('a' + char2);
                    for (int char3 = 0; char3 < n; char3++)
                    {
                        char thirdChar = (char)('a' + char3);
                        Console.WriteLine($"{firstChar}{secondChar}{thirdChar}");
                    }
                }
            }
        }
    }
}
