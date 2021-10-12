using System;
using System.Collections.Generic;
using System.Text;

namespace GenericSwapMethodInteger
{
    public class Box
    {
        private List<int> items;

        public Box()
        {
            this.items = new List<int>();
        }

        public void Add(int item)
        {
            items.Add(item);
        }
        public void Swap(int first, int second)
        {
            int firstString = items[first];
            items[first] = items[second];
            items[second] = firstString;
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
