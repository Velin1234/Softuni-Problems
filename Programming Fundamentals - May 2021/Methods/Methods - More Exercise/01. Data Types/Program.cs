using System;

namespace _01._Data_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            switch (type)
            {
                case "int":
                    Console.WriteLine(DataInt()); 
                    break;
                case "real":
                    Console.WriteLine($"{DataReal():f2}");
                    break;
                case "string":
                    Console.WriteLine(DataString());
                    break;
            }
        }

        static int DataInt()
        {
            int number = int.Parse(Console.ReadLine());
            int result = number * 2;
            return result;
        }

        static double DataReal()
        {
            double number = double.Parse(Console.ReadLine());
            double result = number*1.5;
            return result;
        }

        static string DataString()
        {
            string word = Console.ReadLine();
            string result = '$' + word + '$';
            return result;
        }
    }
}
