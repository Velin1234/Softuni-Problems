using System;

namespace _05._Print_Part_Of_ASCII_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int charCode1 = int.Parse(Console.ReadLine());
            int charCode2 = int.Parse(Console.ReadLine());

            for (int i = charCode1; i <= charCode2; i++)
            {
                Console.Write((char)i +" ");
            }
        }
    }
}
