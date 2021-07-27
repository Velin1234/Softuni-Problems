using System;

namespace _03.Logistics
{
    class Program
    {
        static void Main(string[] args)
        {
            int cargo = int.Parse(Console.ReadLine());
            decimal wholeCargo = 0;
            const decimal microbusPicePerTon = 200;
            const decimal truckPricePerTon = 175;
            const decimal traintPricePerTon = 120;
            decimal microbusTons = 0;
            decimal truckTons = 0;
            decimal trainTons = 0;

            for (int eachCargo = 1; eachCargo <= cargo; eachCargo++)
            {
                int weighEachCargo = int.Parse(Console.ReadLine());
                wholeCargo += weighEachCargo;
                if (weighEachCargo <= 3)
                {
                    microbusTons += weighEachCargo;
                }
                else if (weighEachCargo >= 4 && weighEachCargo <= 11)
                {
                    truckTons += weighEachCargo;
                }
                else if (weighEachCargo >= 12)
                {
                    trainTons += weighEachCargo;
                }
            }

            decimal avgPricePerTon = (microbusTons * microbusPicePerTon + truckTons * truckPricePerTon + trainTons * traintPricePerTon) / wholeCargo;
            decimal percentMicrobus = microbusTons / wholeCargo * 100;
            decimal percentTruck = truckTons / wholeCargo * 100;
            decimal percentTrain = trainTons / wholeCargo * 100;


            Console.WriteLine($"{avgPricePerTon:f2}");
            Console.WriteLine($"{percentMicrobus:f2}%");
            Console.WriteLine($"{percentTruck:f2}%");
            Console.WriteLine($"{percentTrain:f2}%");
        }
    }
}
