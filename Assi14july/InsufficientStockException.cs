using System;
using System.Collections.Generic;

class InsufficientStockException : Exception
{
    public InsufficientStockException(string message) : base(message)
    {
    }
}

class Item
{
    public int ItemId { get; set; }
    public string ItemName { get; set; }
    public double Price { get; set; }
    public int Quantity { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        List<Item> itemList = new List<Item>();

        itemList.Add(new Item
        {
            ItemId = 101,
            ItemName = "Notebook",
            Price = 100,
            Quantity = 10
        });

        itemList.Add(new Item
        {
            ItemId = 102,
            ItemName = "Pen",
            Price = 20,
            Quantity = 15
        });

        itemList.Add(new Item
        {
            ItemId = 103,
            ItemName = "Marker",
            Price = 50,
            Quantity = 5
        });

        try
        {
            Console.Write("Enter Item Id: ");
            int id = Convert.ToInt32(Console.ReadLine());

            Item item = itemList.Find(i => i.ItemId == id);

            if (item == null)
            {
                Console.WriteLine("Item not found.");
                return;
            }

            Console.Write("Enter Quantity: ");
            int purchaseQty = Convert.ToInt32(Console.ReadLine());

            if (purchaseQty > item.Quantity)
            {
                throw new InsufficientStockException("Insufficient Stock.");
            }

            item.Quantity = item.Quantity - purchaseQty;

            double amount = item.Price * purchaseQty;
            double discount = amount * 10 / 100;
            double gst = (amount - discount) * 18 / 100;
            double total = (amount - discount) + gst;

            Console.WriteLine("--------------------------------");
            Console.WriteLine("Item      : " + item.ItemName);
            Console.WriteLine("Price     : " + item.Price);
            Console.WriteLine("Quantity  : " + purchaseQty);
            Console.WriteLine("Discount  : " + discount);
            Console.WriteLine("GST       : " + gst);
            Console.WriteLine("Total     : " + total);
            Console.WriteLine("--------------------------------");

            Console.WriteLine("Remaining Stock : " + item.Quantity);
        }
        catch (InsufficientStockException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}