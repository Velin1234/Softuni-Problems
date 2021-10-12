using System;

namespace GenericBoxOfString
{
    class StartUp
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            Box box = new Box();

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                box.Add(input);
            }
            Console.WriteLine(box);
        }
    }
}

