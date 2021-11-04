using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SkiRental
{
    public class SkiRental
    {
        public SkiRental(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
            Data = new List<Ski>();
        }

        public string Name { get; set; }
        public int Capacity { get; set; }
        public List<Ski> Data { get; set; }
        public int Count => Data.Count;

        public void Add(Ski ski)
        {
            if (Data.Count + 1 <= Capacity)
            {
                Data.Add(ski);
            }
        }

        public bool Remove(string manufacturer, string model)
        {
            Ski skiToRemove = Data.FirstOrDefault(s => s.Manufacturer == manufacturer && s.Model == model);
            if (skiToRemove == null)
            {
                return false;
            }

            Data.Remove(skiToRemove);
            return true;
        }

        public Ski GetNewestSki()
        => Data.OrderByDescending(s => s.Year).FirstOrDefault();
        public Ski GetSki(string manufacturer, string model)
        => Data.FirstOrDefault(s => s.Manufacturer == manufacturer && s.Model == model);

        public string GetStatistics()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"The skis stored in {Name}:");
            foreach (var ski in Data)
            {
                sb.AppendLine(ski.ToString());
            }
            return sb.ToString();
        }
    }
}
