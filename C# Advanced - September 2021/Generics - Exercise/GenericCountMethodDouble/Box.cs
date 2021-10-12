using System;
using System.Collections.Generic;
using System.Text;

namespace GenericCountMethodDouble
{
    public class Box<T>
        where T : IComparable
    {
        private List<T> items;

        public Box()
        {
            this.items = new List<T>();
        }

        public void Add(T item)
        {
            items.Add(item);
        }
        public void Swap(int first, int second)
        {
            T firstString = items[first];
            items[first] = items[second];
            items[second] = firstString;
        }
        public int CountGreaterThan(T item)
        {
            int count = 0;
            foreach (var element in items)
            {
                if (element.CompareTo(item) > 0)
                {
                    count++;
                }
            }
            return count;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in items)
            {
                sb.AppendLine(item.GetType() + ": " + item);
            }
            return sb.ToString().TrimEnd();
        }
    }
}
