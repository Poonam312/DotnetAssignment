class Item
{
    public int ItemId { get; set; }
    public string ItemName { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        List<Item> itemList = new List<Item>();

        itemList.Add(new Item { ItemId = 101, ItemName = "Pen" });
        itemList.Add(new Item { ItemId = 102, ItemName = "Notebook" });
        itemList.Add(new Item { ItemId = 103, ItemName = "Marker" });

        Console.Write("Enter Item Id to Delete: ");
        int id = Convert.ToInt32(Console.ReadLine());

        Item item = itemList.Find(i => i.ItemId == id);

        if (item != null)
        {
            Console.Write("Delete? (Y/N): ");
            char choice = Convert.ToChar(Console.ReadLine());

            if (choice == 'Y' || choice == 'y')
            {
                itemList.Remove(item);
                Console.WriteLine("Item deleted successfully.");
            }
            else
            {
                Console.WriteLine("Delete cancelled.");
            }
        }
        else
        {
            Console.WriteLine("Item not found.");
        }

        Console.WriteLine("\nRemaining Items:");

        foreach (Item i in itemList)
        {
            Console.WriteLine(i.ItemId + " " + i.ItemName);
        }
    }
}