using System;
using System.Collections.Generic;
using System.Text;

namespace Threeuple
{
    public class ThreepleClass<Item1, Item2, Item3>
    {

        public Item1 LeftItem { get; set; }
        public Item2 MiddleItem { get; set; }
        public Item3 RightItem { get; set; }

        public ThreepleClass(Item1 leftItem,Item2 middleItem,Item3 rightItem)
        {
            LeftItem = leftItem;
            MiddleItem = middleItem;
            RightItem = rightItem;
        }

        public string GetItems()
        {
            return $"{LeftItem} -> {MiddleItem} -> {RightItem}";
        }
    }
}
