
using System.Collections.Generic;
using System.Linq;

class Sortingeg
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

        itemList.Add(new Item { ItemId = 101, ItemName = "Notebook", Price = 100, Quantity = 10 });
        itemList.Add(new Item { ItemId = 102, ItemName = "Pen", Price = 20, Quantity = 25 });
        itemList.Add(new Item { ItemId = 103, ItemName = "Marker", Price = 50, Quantity = 5 });
        itemList.Add(new Item { ItemId = 104, ItemName = "Pencil", Price = 10, Quantity = 30 });

        Console.WriteLine("Sorting Menu");
        Console.WriteLine("1. Price");
        Console.WriteLine("2. Name");
        Console.WriteLine("3. Quantity");
        Console.Write("Enter your choice: ");

        int choice = Convert.ToInt32(Console.ReadLine());

        switch (choice)
        {
            case 1:
                // Sort by Price using List.Sort()
                itemList.Sort((x, y) => x.Price.CompareTo(y.Price));
                break;

            case 2:
                // Sort by Name using LINQ OrderBy()
                itemList = itemList.OrderBy(x => x.ItemName).ToList();
                break;

            case 3:
                // Sort by Quantity using LINQ OrderByDescending()
                itemList = itemList.OrderByDescending(x => x.Quantity).ToList();
                break;

            default:
                Console.WriteLine("Invalid Choice");
                return;
        }

        Console.WriteLine("\n--------------------------------------------");
        Console.WriteLine("ID\tName\t\tPrice\tQuantity");
        Console.WriteLine("--------------------------------------------");

        foreach (Item item in itemList)
        {
            Console.WriteLine(item.ItemId + "\t" +
                              item.ItemName + "\t\t" +
                              item.Price + "\t" +
                              item.Quantity);
        }
    }
}