using System;

namespace _01._PC_Store
{
    class Program
    {
        static void Main(string[] args)
        {
            double dollarToLev = 1.57;

            double processorPrice = double.Parse(Console.ReadLine());
            double videoCardPrice = double.Parse(Console.ReadLine());
            double ramMemoryPrice = double.Parse(Console.ReadLine());
            int numberRams = int.Parse(Console.ReadLine());
            double percentDiscount = double.Parse(Console.ReadLine());


            double processorLeva = processorPrice * dollarToLev;
            processorLeva -= processorLeva * percentDiscount;

            double videoCardLev = videoCardPrice * dollarToLev;
            videoCardLev -= videoCardLev * percentDiscount;

            
            double priceToLeva = processorLeva + videoCardLev + (ramMemoryPrice * dollarToLev) * numberRams;
            Console.WriteLine($"Money needed - {priceToLeva:f2} leva.");
        }
    }
}
