using SpaceStation.Core.Contracts;
using SpaceStation.Models.Astronauts;
using SpaceStation.Models.Astronauts.Contracts;
using SpaceStation.Models.Mission;
using SpaceStation.Models.Mission.Contracts;
using SpaceStation.Models.Planets;
using SpaceStation.Models.Planets.Contracts;
using SpaceStation.Repositories;
using SpaceStation.Repositories.Contracts;
using SpaceStation.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace SpaceStation.Core
{
    internal class Controller : IController
    {
        private int exploredPlanetsCount = 0;
        private IRepository<IAstronaut> astronautRepository = new AstronautRepository();
        private IRepository<IPlanet> planetRepository = new PlanetRepository();
        public string AddAstronaut(string type, string astronautName)
        {
            IAstronaut astronaut = null;
            switch (type)
            {
                case "Biologist":
                    astronaut = new Biologist(astronautName);
                    astronautRepository.Add(astronaut);
                    break;
                case "Geodesist":
                    astronaut = new Geodesist(astronautName);
                    astronautRepository.Add(astronaut);
                    break;
                case "Meteorologist":
                    astronaut = new Meteorologist(astronautName);
                    astronautRepository.Add(astronaut);
                    break;
                default:
                    throw new InvalidOperationException(ExceptionMessages.InvalidAstronautType);

            }
            return string.Format(OutputMessages.AstronautAdded, type, astronautName);
        }

        public string AddPlanet(string planetName, params string[] items)
        {
            IPlanet planet = new Planet(planetName);
            foreach (var item in items)
            {
                planet.Items.Add(item);
            }
            planetRepository.Add(planet);
            return string.Format(OutputMessages.PlanetAdded, planetName);
        }

        public string ExplorePlanet(string planetName)
        {
            IMission mission = new Mission();
            var planet = planetRepository.FindByName(planetName);
            var astronauts = astronautRepository.Models.Where(a => a.Oxygen >= 60).ToList();
            if (astronauts.Count == 0)
            {
                throw new InvalidOperationException(ExceptionMessages.InvalidAstronautCount);
            }
            exploredPlanetsCount++;
            mission.Explore(planet, astronauts);
            int deadAstronauts = astronauts.Where(a => a.Oxygen <= 0).ToList().Count;
            return string.Format(OutputMessages.PlanetExplored, planetName, deadAstronauts);
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{exploredPlanetsCount} planets were explored!");
            sb.AppendLine("Astronauts info:");
            foreach (var astronaut in astronautRepository.Models)
            {
                sb.AppendLine($"Name: " + astronaut.Name);
                sb.AppendLine($"Oxygen: " + astronaut.Oxygen);
                if (astronaut.Bag.Items.Count > 0)
                {
                    sb.AppendLine($"Bag items: {string.Join(", ", astronaut.Bag.Items)}");
                }
                else
                {
                    sb.AppendLine($"Bag items: none");
                }
            }
            return sb.ToString().TrimEnd();
        }

        public string RetireAstronaut(string astronautName)
        {
            var astronaut = astronautRepository.FindByName(astronautName);
            if (astronaut == null)
            {
                throw new InvalidOperationException(string.Format(ExceptionMessages.InvalidRetiredAstronaut, astronautName));
            }
            astronautRepository.Remove(astronaut);
            return string.Format(OutputMessages.AstronautRetired, astronautName);
        }
    }
}
