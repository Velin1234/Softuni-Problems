using System;
using System.Collections.Generic;
using System.Text;

namespace GenericSwapMethodString
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
        public void Swap(int first,int second)
        {
            string firstString = items[first];
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
