using System;
using System.Collections.Generic;
using System.Linq;

namespace CarData
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] carData = Console.ReadLine().Split(" ");

                string model = carData[0];
                //Engine
                int engineSpeed = Convert.ToInt32(carData[1]);
                int enginePower = Convert.ToInt32(carData[2]);
                Engine engine = new Engine(engineSpeed, enginePower);
                //Cargo
                int cargoWeight = Convert.ToInt32(carData[3]);
                string cargoType = carData[4];
                Cargo cargo = new Cargo(cargoType, cargoWeight);
                //Tires
                double tire1Pressure = Convert.ToDouble(carData[5]);
                int tire1Age = Convert.ToInt32(carData[6]);
                Tire tire1 = new Tire(tire1Pressure, tire1Age);
                double tire2Pressure = Convert.ToDouble(carData[7]);
                int tire2Age = Convert.ToInt32(carData[8]);
                Tire tire2 = new Tire(tire2Pressure, tire2Age);
                double tire3Pressure = Convert.ToDouble(carData[9]);
                int tire3Age = Convert.ToInt32(carData[10]);
                Tire tire3 = new Tire(tire3Pressure, tire3Age);
                double tire4Pressure = Convert.ToDouble(carData[11]);
                int tire4Age = Convert.ToInt32(carData[12]);
                Tire tire4 = new Tire(tire4Pressure, tire4Age);
                Tire[] tires = new Tire[4] { tire1, tire2, tire3, tire4 };

                //Car
                Car car = new Car(model, engine, cargo, tires);
                cars.Add(car);
            }
            string choosenCargoType = Console.ReadLine();

            switch (choosenCargoType)
            {
                case "fragile":
                    bool rightTire = false;
                    foreach (var car in cars.Where(p => p.Cargo.Type == "fragile"))
                    {
                        foreach (var tire in car.Tires)
                        {
                            if (tire.Pressure < 1)
                            {
                                rightTire = true;
                            }
                        }
                        if (rightTire)
                        {
                            Console.WriteLine(car.Model);
                        }
                    }
                    
                    break;
                case "flammable":
                    foreach (var car in cars.Where(p => p.Cargo.Type =="flammable" && p.Engine.Power>250))
                    {
                        Console.WriteLine(car.Model);
                    }
                    break;
            }

        }
    }
}
