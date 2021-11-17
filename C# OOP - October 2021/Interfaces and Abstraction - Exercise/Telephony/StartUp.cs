using System;
using System.Linq;

namespace Telephony
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Smartphone smartphone = new Smartphone();
            StationaryPhone stationary = new StationaryPhone();
            string[]numbers = Console.ReadLine().Split(' ').ToArray();
            foreach (var number in numbers)
            {
                if (number.Length == 7)
                {
                    Console.WriteLine(stationary.Call(number)); 
                }
                else if (number.Length == 10)
                {
                    Console.WriteLine(smartphone.Call(number));
                }
                else
                {
                    Console.WriteLine("Invalid number!");
                }
            }
            string[]sites = Console.ReadLine().Split(' ').ToArray();
            foreach (var siteUrl in sites)
            {
                Console.WriteLine(smartphone.Browse(siteUrl));
            }
        }
    }
}
