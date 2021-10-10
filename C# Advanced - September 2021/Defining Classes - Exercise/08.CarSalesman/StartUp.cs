using System;
using System.Collections.Generic;
using System.Linq;

namespace CarSalesman
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int numEngines = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();
            List<Engine> engines = new List<Engine>();
            for (int i = 0; i < numEngines; i++)
            {
                string[] engineInfo = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);
                string engineName = engineInfo[0];
                int enginePower = Convert.ToInt32(engineInfo[1]);
                Engine engine = new Engine(engineName, enginePower);

                try
                {
                    if (Int32.TryParse(engineInfo[2], out _))
                    {
                        engine.Displacement = engineInfo[2];
                    }
                    else
                    {
                        engine.Efficiency = engineInfo[2];
                    }
                    if (Int32.TryParse(engineInfo[3], out _))
                    {
                        engine.Displacement = engineInfo[3];
                    }
                    else
                    {
                        engine.Efficiency = engineInfo[3];
                    }

                }
                catch (Exception)
                {
                }
                engines.Add(engine);
            }
            
            int numCars = int.Parse(Console.ReadLine());
            for (int i = 0; i < numCars; i++)
            {
                string[] carInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string carModel = carInfo[0];
                Car newCar = new Car(carModel, engines.First(e => e.Model == carInfo[1]));
                try
                {
                    if (Int32.TryParse(carInfo[2], out _))
                    {
                        newCar.Weight = carInfo[2];
                    }
                    else
                    {
                        newCar.Color = carInfo[2];
                    }
                    if (Int32.TryParse(carInfo[3], out _))
                    {
                        newCar.Weight = carInfo[3];
                    }
                    else
                    {
                        newCar.Color = carInfo[3];
                    }
                }
                catch (Exception)
                {
                }
                cars.Add(newCar);
            }

            Console.WriteLine(string.Join(Environment.NewLine, cars));
        }
    }
}
