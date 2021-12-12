using Gym.Models.Athletes.Contracts;
using Gym.Models.Equipment.Contracts;
using Gym.Models.Gyms.Contracts;
using Gym.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gym.Models.Gyms
{
    internal abstract class Gym : IGym
    {
        private string name;
        private int capacity;
        private double equipmentWeight;
        private List<IEquipment> equipments = new List<IEquipment>();
        private List<IAthlete> athletes = new List<IAthlete>();

        protected Gym(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
            EquipmentWeight = equipmentWeight;
            Equipment = equipments;
            Athletes = athletes;
        }

        public string Name
        {
            get => name;
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException(ExceptionMessages.InvalidGymName);
                }
                name = value;
            }
        }
        public int Capacity { get => capacity; private set => capacity = value; }
        public ICollection<IEquipment> Equipment { get => equipments; private set => equipments = value.ToList(); }
        public ICollection<IAthlete> Athletes { get => athletes; private set => athletes = value.ToList(); }
        public double EquipmentWeight
        {
            get => equipmentWeight;
            private set
            {
                equipmentWeight = value;
            }
        }
        public void AddAthlete(IAthlete athlete)
        {
            if (capacity < athletes.Count + 1)
            {
                throw new InvalidOperationException(ExceptionMessages.NotEnoughSize);
            }
            athletes.Add(athlete);
        }

        public void AddEquipment(IEquipment equipment)
        {
            equipments.Add(equipment);
            equipmentWeight += equipment.Weight;
        }

        public void Exercise()
        {
            foreach (IAthlete athlete in athletes)
            {
                athlete.Exercise();
            }
        }

        public string GymInfo()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{this.Name} is a {GetType().Name}");
            if (athletes.Count == 0)
            {
                sb.AppendLine("Athletes: No athletes");
            }
            else
            {
                var athleteNames = athletes.Select(athlete => athlete.FullName).ToList();
                sb.AppendLine($"Athletes: {string.Join(", ", athleteNames)}");
            }
            sb.AppendLine($"Equipment total count: {equipments.Count}");
            sb.AppendLine($"Equipment total weight: {equipmentWeight:f2} grams");
            return sb.ToString();
        }

        public bool RemoveAthlete(IAthlete athlete)
        {
            return athletes.Remove(athlete);
        }
    }
}
