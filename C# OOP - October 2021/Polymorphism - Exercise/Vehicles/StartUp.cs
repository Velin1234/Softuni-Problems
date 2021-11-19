using System;
using System.Linq;

namespace Vehicles
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] carInfo = Console.ReadLine().Split(' ').ToArray();
            Vehicle car = new Car(Convert.ToDouble(carInfo[1]), Convert.ToDouble(carInfo[2]), Convert.ToDouble(carInfo[3]));
            car.CheckTank();
            string[] truckInfo = Console.ReadLine().Split(' ').ToArray();
            Vehicle truck = new Truck(Convert.ToDouble(truckInfo[1]), Convert.ToDouble(truckInfo[2]), Convert.ToDouble(truckInfo[3]));
            truck.CheckTank();
            string[] busInfo = Console.ReadLine().Split(' ').ToArray();
            Vehicle bus = new Bus(Convert.ToDouble(busInfo[1]), Convert.ToDouble(busInfo[2]), Convert.ToDouble(busInfo[3]));
            bus.CheckTank();
            int numComands = int.Parse(Console.ReadLine());
            for (int i = 0; i < numComands; i++)
            {
                string[] cmdArgs = Console.ReadLine().Split(' ').ToArray();
                switch (cmdArgs[1])
                {
                    case "Car":
                        switch (cmdArgs[0])
                        {
                            case "Drive":
                                car.Drive(Convert.ToDouble(cmdArgs[2]));
                                break;
                            case "Refuel":
                                car.Refuel(Convert.ToDouble(cmdArgs[2]));
                                break;
                        }
                        break;
                    case "Truck":
                        switch (cmdArgs[0])
                        {
                            case "Drive":
                                truck.Drive(Convert.ToDouble(cmdArgs[2]));
                                break;
                            case "Refuel":
                                truck.Refuel(Convert.ToDouble(cmdArgs[2]));
                                break;
                        }
                        break;
                    case "Bus":
                        switch (cmdArgs[0])
                        {
                            case "Drive":
                                bus.Drive(Convert.ToDouble(cmdArgs[2]));
                                break;
                            case "Refuel":
                                bus.Refuel(Convert.ToDouble(cmdArgs[2]));
                                break;
                            case "DriveEmpty":
                                bus.DriveEmpty(Convert.ToDouble(cmdArgs[2]));
                                break;
                        }
                        break;
                }
            }
            Console.WriteLine(car);
            Console.WriteLine(truck);
            Console.WriteLine(bus);
        }
       
    }
}
