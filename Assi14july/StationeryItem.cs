
class StationeryItem
{
    // Properties
    public int ItemId { get; set; }
    public string ItemName { get; set; }
    public string Category { get; set; }
    public double Price { get; set; }
    public int Quantity { get; set; }
    public string Brand { get; set; }

    // Method to display item details
    public void DisplayDetails()
    {
        Console.WriteLine("Item Id      : " + ItemId);
        Console.WriteLine("Item Name    : " + ItemName);
        Console.WriteLine("Category     : " + Category);
        Console.WriteLine("Price        : " + Price);
        Console.WriteLine("Quantity     : " + Quantity);
        Console.WriteLine("Brand        : " + Brand);
    }

    // Method to update quantity
    public void UpdateQuantity(int newQuantity)
    {
        Quantity = newQuantity;
        Console.WriteLine("Quantity Updated Successfully.");
    }
}

class Program
{
    static void Main()
    {
        StationeryItem item = new StationeryItem();

        item.ItemId = 101;
        item.ItemName = "Pen";
        item.Category = "Writing";
        item.Price = 20;
        item.Quantity = 50;
        item.Brand = "Cello";

        Console.WriteLine("Item Details");
        item.DisplayDetails();

        Console.WriteLine();

        item.UpdateQuantity(100);

        Console.WriteLine();
        Console.WriteLine("Updated Details");
        item.DisplayDetails();
    }
}

