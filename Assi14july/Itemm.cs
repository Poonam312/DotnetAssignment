using System.Collections.Generic;
class Itemm
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

        itemList.Add(new Item { ItemId = 101, ItemName = "Pen", Price = 20, Quantity = 10 });
        itemList.Add(new Item { ItemId = 102, ItemName = "Notebook", Price = 100, Quantity = 3 });
        itemList.Add(new Item { ItemId = 103, ItemName = "Marker", Price = 50, Quantity = 2 });
        itemList.Add(new Item { ItemId = 104, ItemName = "Pencil", Price = 10, Quantity = 8 });

        Console.WriteLine("Low Stock Items");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("ID\tName\t\tPrice\tQuantity");
        Console.WriteLine("------------------------------------------");

        foreach (Item item in itemList)
        {
            if (item.Quantity < 5)
            {
                Console.WriteLine(item.ItemId + "\t" +
                                  item.ItemName + "\t\t" +
                                  item.Price + "\t" +
                                  item.Quantity);
            }
        }
    }
}