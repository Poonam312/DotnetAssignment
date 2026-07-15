using System.Collections.Generic;

class Programm
{
    static void Main()
    {
        // List to store all stationery items
        List<StationeryItem> items = new List<StationeryItem>();

        // Add Items
        items.Add(new StationeryItem
        {
            ItemId = 101,
            ItemName = "Notebook",
            Category = "Books",
            Price = 80,
            Quantity = 20,
            Brand = "Classmate"
        });

        items.Add(new StationeryItem
        {
            ItemId = 102,
            ItemName = "Pen",
            Category = "Writing",
            Price = 20,
            Quantity = 50,
            Brand = "Cello"
        });

        items.Add(new StationeryItem
        {
            ItemId = 103,
            ItemName = "Marker",
            Category = "Writing",
            Price = 35,
            Quantity = 15,
            Brand = "Camlin"
        });

        Console.WriteLine("Stationery Items\n");

        foreach (StationeryItem item in items)
        {
            item.DisplayDetails();
            Console.WriteLine();
        }
    }
}