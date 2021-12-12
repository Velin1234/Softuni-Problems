using SpaceStation.Models.Astronauts.Contracts;
using SpaceStation.Models.Mission.Contracts;
using SpaceStation.Models.Planets.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpaceStation.Models.Mission
{
    internal class Mission : IMission
    {
        public void Explore(IPlanet planet, ICollection<IAstronaut> astronauts)
        {
            foreach (var astronaut in astronauts)
            {
                while (astronaut.CanBreath == true)
                {
                    if (planet.Items.Count == 0)
                    {
                        break;
                    }
                    foreach (var item in planet.Items.ToList())
                    {
                        if (astronaut.CanBreath != true)
                        {
                            break;
                        }
                        astronaut.Breath();
                        astronaut.Bag.Items.Add(item);
                        planet.Items.Remove(item);
                    }
                }
            }
        }
    }
}
