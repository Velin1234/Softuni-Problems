using System;
using System.IO;

namespace _02._Line_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader(@"C:\Users\venit\Downloads\Resources\02. Line Numbers\Input.txt"))
            {
                var line = sr.ReadLine();
                int num = 1;
                while (line != null)
                {
                    Console.WriteLine($"{num}. {line}");
                    line = sr.ReadLine();
                    num++;
                }
            }
        }
    }
}
