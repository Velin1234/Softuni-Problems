using System;
using System.Collections.Generic;
using System.Text;

namespace CarData
{
    class Car
    {
        private string model;
        private Engine engine;
        private Cargo cargo;
        private Tire[] tires;

        public Car(string model, Engine engine, Cargo cargo, Tire[] tires)
        {
            Model = model;
            Engine = engine;
            Cargo = cargo;
            Tires = tires;
        }

        public string Model { get => model; set => model = value; }
        public Engine Engine { get => engine; set => engine = value; }
        public Cargo Cargo { get => cargo; set => cargo = value; }
        public Tire[] Tires { get => tires; set => tires = value; }

    }
}
