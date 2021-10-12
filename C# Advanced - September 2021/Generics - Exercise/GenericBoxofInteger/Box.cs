using System;
using System.Collections.Generic;
using System.Text;

namespace GenericBoxofInteger
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
