using System;
using System.Linq;

namespace GenericSwapMethodString
{
    public class StartUp
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
            int[] swapDigits = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            box.Swap(swapDigits[0],swapDigits[1]);
            Console.WriteLine(box);
        }
    }
}
