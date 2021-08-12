using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Extract_file
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> filePlace = Console.ReadLine().Split("\\").ToList();
            string [] file = filePlace[filePlace.Count - 1].Split(".");
            Console.WriteLine($"File name: {file[0]}");
            Console.WriteLine($"File extension: {file[1]}");

        }
    }
}
