using System;
using System.IO;

namespace _01._Odd_Lines
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader(@"C:\Users\venit\Downloads\Resources\01. Odd Lines\Input.txt"))
            {
                int counter = 0;
                string line = sr.ReadLine();
                while (line != null)
                {
                    if (counter % 2 == 1)
                    {
                        Console.WriteLine(line);
                    }
                    counter++;
                    line = sr.ReadLine();
                }
            }
        }
    }
}
