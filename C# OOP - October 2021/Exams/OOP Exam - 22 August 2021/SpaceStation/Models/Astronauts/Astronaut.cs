using SpaceStation.Models.Astronauts.Contracts;
using SpaceStation.Models.Bags;
using SpaceStation.Models.Bags.Contracts;
using SpaceStation.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceStation.Models.Astronauts
{
    internal abstract class Astronaut : IAstronaut
    {
        private string name;
        private double oxygen;
        private bool canBreath;

        public Astronaut(string name, double oxygen)
        {
            Name = name;
            Oxygen = oxygen;
            CanBreath = true;
            Bag = new Backpack();
        }

        public string Name
        {
            get { return name; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException(ExceptionMessages.InvalidAstronautName);
                }
                name = value;
            }
        }

        public double Oxygen
        {
            get { return oxygen; }
            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentException(ExceptionMessages.InvalidOxygen);
                }
                oxygen = value;
            }
        }

        public bool CanBreath
        {
            get { return canBreath; }
            protected set
            {
                canBreath = value;
            }
        }
        public IBag Bag { get; private set; }

        public virtual void Breath()
        {
            this.oxygen -= 10;
            if (oxygen <= 0)
            {
                canBreath = false;
            }
        }
    }
}
