using System;
using System.Collections.Generic;
using System.Linq;

namespace StoreBoxes
{
    public class Item
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public Item(string name,decimal price)
        {
            Name = name;
            Price = price;

        }
    }
    public class Box
    {
        public string SerialNumber { get; set; }
        public Item Item { get; set; }
        public int ItemQuantity { get; set; }
        public decimal PriceForABox { get; set; }
        public Box(string serialNumber,Item item,int itemQuantity,decimal priceForABox)
        {
            SerialNumber = serialNumber;
            Item = item;
            ItemQuantity = itemQuantity;
            PriceForABox = priceForABox;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Box> boxes = new List<Box>();

            string line = Console.ReadLine();
            while (line != "end")
            {
                
                
                string[] input = line.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string serialNumber = input[0];
                string itemName = input[1];
                int itemQuantity = int.Parse(input[2]);
                decimal itemPrice =decimal.Parse( input[3]);

                decimal priceOfOneBox = itemQuantity * itemPrice;
                Item item = new Item(itemName, itemPrice);
                Box box = new Box(serialNumber, item, itemQuantity, priceOfOneBox);
                boxes.Add(box);
                line = Console.ReadLine();
            }
     List<Box> sortedBoxes=  boxes.OrderBy(i =>i.PriceForABox).ToList();
            sortedBoxes.Reverse();
            foreach (var box in sortedBoxes)
            {
                Item item = box.Item;
                Console.WriteLine(box.SerialNumber);
                Console.WriteLine($"-- {item.Name} - ${item.Price:f2}: {box.ItemQuantity}");
                Console.WriteLine($"-- ${box.PriceForABox:f2}");
            }
           
        }
    }
}
