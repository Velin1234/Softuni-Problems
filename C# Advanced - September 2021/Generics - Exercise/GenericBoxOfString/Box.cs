using System;
using System.Collections.Generic;
using System.Text;

namespace GenericBoxOfString
{
    public class Box
    {
        private List<string> items;

        public Box()
        {
            this.items = new List<string>();
        }

        public void Add(string item)
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

