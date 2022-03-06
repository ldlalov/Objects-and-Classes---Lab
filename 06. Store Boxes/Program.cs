using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Store_Boxes
{
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

        public string SerialNumber { get; set; }
        public Item Item { get; set; }
        public int ItemQuantity { get; set; }
        public double BoxPrice { get; set; }
    }

    internal partial class Program
    {
        static void Main(string[] args)
        {
            List<Box> boxes = new List<Box>();
            string input;
            while ((input=Console.ReadLine()) != "end")
            {
                string[] parts = input.Split(' ');
                string serialNumber = parts[0];
                string itemName = parts[1];
                int itemQuantity = int.Parse(parts[2]);
                double itemPrice = double.Parse(parts[3]);
                Box box = new Box();
                box.SerialNumber = serialNumber;
                box.Item.Name = itemName;
                box.Item.Price = itemPrice;
                box.ItemQuantity = itemQuantity;
                box.BoxPrice = itemQuantity * itemPrice;
                boxes.Add(box);
            }
            List<Box> orderedBoxes = boxes.OrderBy(box => box.BoxPrice).ToList();
            orderedBoxes.Reverse();
            foreach (Box box in orderedBoxes)
            {
                Console.WriteLine($"{box.SerialNumber}");
                Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:f2}: {box.ItemQuantity}");
                Console.WriteLine($"-- ${box.BoxPrice:f2}");
            }
        }
    }
}
