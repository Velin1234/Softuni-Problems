using System;

namespace _09._Greater_of_Two_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            switch (type)
            {
                case "int":
                    int num1 = int.Parse(Console.ReadLine());
                    int num2 = int.Parse(Console.ReadLine());
                    GetMaxInt(num1, num2);
                    break;
                
                case "char":
                    char char1 = Convert.ToChar(Console.ReadLine());
                    char char2 = Convert.ToChar(Console.ReadLine());
                    GetMaxChar(char1, char2);
                    break;
                
                case "string":
                    string string1 = Console.ReadLine();
                    string string2 = Console.ReadLine();
                    GetMaxString(string1, string2);
                    break;
            }
        }

        static void GetMaxInt(int num1 , int num2)
        {
            if (num1 > num2)
            {
                Console.WriteLine(num1);
                return;
            }
            Console.WriteLine(num2);
            return;
        }

        static void GetMaxChar(char char1 , char char2)
        {
            if (char1 > char2)
            {
                Console.WriteLine(char1);
                return;
            }
            Console.WriteLine(char2);
            return;
        }

        static void GetMaxString(string string1, string string2)
        {
            if (String.Compare(string1,string2) > 0)
            {
                Console.WriteLine(string1);
                return;
            }
            Console.WriteLine(string2);
            return;
        }
    }
}
