using System;

namespace _01._Supplies_for_School
{
    class Program
    {
        static void Main(string[] args)
        {
            double pensPackage = 5.80;
            double markersPackage = 7.20;
            double literChemichal = 1.20;

            int pens = int.Parse(Console.ReadLine());
            int markers = int.Parse(Console.ReadLine());
            double litersBoardCleaner = double.Parse(Console.ReadLine());
            int percentsDiscount = int.Parse(Console.ReadLine());

            double wholePrice = (pens * pensPackage) + (markers * markersPackage) + (litersBoardCleaner * literChemichal);
            wholePrice -= wholePrice * percentsDiscount / 100;
            Console.WriteLine($"{wholePrice:f3}");
        }
    }
}
