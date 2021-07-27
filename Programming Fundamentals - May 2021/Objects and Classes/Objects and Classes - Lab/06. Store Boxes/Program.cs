using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Store_Boxes
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ");
            List<Box> Boxes = new List<Box>();
            while (input[0] != "end")
            {
                int serialnumber = Convert.ToInt32(input[0]);
                string itemName = input[1];
                int itemQuantity = Convert.ToInt32(input[2]);
                double itemPrice = Convert.ToDouble(input[3]);

                Item item = new Item();
                item.Name = itemName;
                item.Price = itemPrice;
                
                Box box = new Box();
                box.SerialNumber = serialnumber;
                box.Item = item;
                box.ItemQuanity = itemQuantity;
                box.BoxPrice = item.Price * itemQuantity;

                Boxes.Add(box);

                input = Console.ReadLine().Split(" ");
            }

            List<Box> filteredBoxes = Boxes.OrderByDescending(b => b.BoxPrice).ToList();


            foreach (Box box in filteredBoxes)
            {
                Console.WriteLine($"{box.SerialNumber} \n" +
                    $"-- {box.Item.Name} - ${box.Item.Price:f2}: {box.ItemQuanity} \n" +
                    $"-- ${box.BoxPrice:f2}");
            }
        }
    }

    class Item
    {
        public string Name { get; set; }
        public double Price { get; set; }
    }
    
    class Box
    {
        public Box()
        {
            Item = new Item();
        }
        public int SerialNumber { get; set; }
        public Item Item { get; set; }
        public int ItemQuanity { get; set; }
        public double BoxPrice { get; set; }
    }
}
