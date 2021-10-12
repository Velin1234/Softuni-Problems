using System;

namespace Tuple
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] nameTownInput = Console.ReadLine().Split(" ");
            string name = $"{nameTownInput[0]} {nameTownInput[1]}";
            string town = nameTownInput[2];
            TupleClass<string, string> nameTown = new TupleClass<string, string>(name, town);

            string[] nameBeerInput = Console.ReadLine().Split();
            string beerName = nameBeerInput[0];
            int liters = int.Parse(nameBeerInput[1]);
            TupleClass<string, int> nameBeer = new TupleClass<string, int>(beerName, liters);

            string[] numberInput = Console.ReadLine().Split();
            int integer = int.Parse(numberInput[0]);
            double doubleNumber = double.Parse(numberInput[1]);
            TupleClass<int, double> numbers = new TupleClass<int, double>(integer, doubleNumber);

            Console.WriteLine(nameTown.GetItems());
            Console.WriteLine(nameBeer.GetItems());
            Console.WriteLine(numbers.GetItems());

        }
    }
}
