using System;

namespace Threeuple
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] nameTownInput = Console.ReadLine().Split();
            string name = $"{nameTownInput[0]} {nameTownInput[1]}";
            string street = nameTownInput[2];
            string town = nameTownInput.Length > 4 ? nameTownInput[3] + " " + nameTownInput[4] : nameTownInput[3];
            ThreepleClass<string, string, string> nameTown = new ThreepleClass<string, string, string>(name, street, town);

            string[] nameBeerInput = Console.ReadLine().Split();
            string beerName = nameBeerInput[0];
            int liters = int.Parse(nameBeerInput[1]);
            bool drunk = false;
            if (nameBeerInput[2] == "drunk")
            {
                drunk = true;
            }
            ThreepleClass<string, int, bool> nameBeer = new ThreepleClass<string, int, bool>(beerName, liters, drunk);

            string[] bankInput = Console.ReadLine().Split();
            string customerName = bankInput[0];
            double doubleNumber = double.Parse(bankInput[1]);
            string bankName = bankInput[2];
            ThreepleClass<string, double, string> bankInfo = new ThreepleClass<string, double, string>(customerName, doubleNumber, bankName);

            Console.WriteLine(nameTown.GetItems());
            Console.WriteLine(nameBeer.GetItems());
            Console.WriteLine(bankInfo.GetItems());
        }
    }
}
