using System;
using System.Linq;

namespace _02._Array_Modifier
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            string[] commands = Console.ReadLine().Split(" ");

            while (commands[0] != "end")
            {
                
                
                switch (commands[0])
                {
                    case "swap":
                        int index1 = Convert.ToInt32(commands[1]);
                        int index2 = Convert.ToInt32(commands[2]);
                        int oldPosition = numbers[index1];
                        numbers[index1] = numbers[index2];
                        numbers[index2] = oldPosition;
                        break;

                    case "multiply":
                        index1 = Convert.ToInt32(commands[1]);
                        index2 = Convert.ToInt32(commands[2]);
                        numbers[index1] = numbers[index1] * numbers[index2];
                        break;

                    case "decrease":
                        for (int i = 0; i < numbers.Length; i++)
                        {
                            numbers[i]--;
                        }
                        
                        break;
                }
                commands = Console.ReadLine().Split(" ");
            }

            Console.WriteLine(string.Join(", ",numbers));
        }
    }
}
