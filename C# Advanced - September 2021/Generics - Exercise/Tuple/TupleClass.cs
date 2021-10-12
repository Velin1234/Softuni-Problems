using System;
using System.Collections.Generic;
using System.Text;

namespace Tuple
{
    public class TupleClass<Item1, Item2>
    {
        public Item1 LeftItem { get; set; }
        public Item2 RightItem { get; set; }

        public TupleClass(Item1 leftItem, Item2 rightItem)
        {
            LeftItem = leftItem;
            RightItem = rightItem;
        }

        public string GetItems()
        {
            return $"{LeftItem} -> {RightItem}";
        }
    }
}
