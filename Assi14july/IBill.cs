

using System;

// Interface
interface IBill
{
    void GenerateBill();
}

// Purchase Class
class Purchase : IBill
{
    public string ProductName { get; set; }
    public int Quantity { get; set; }
    public double Price { get; set; }

    public void GenerateBill()
    {
        double total = Quantity * Price;

        Console.WriteLine("----- Bill -----");
        Console.WriteLine("Product Name : " + ProductName);
        Console.WriteLine("Quantity     : " + Quantity);
        Console.WriteLine("Price        : " + Price);
        Console.WriteLine("Total Amount : " + total);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Purchase purchase = new Purchase();

        Console.Write("Enter Product Name: ");
        purchase.ProductName = Console.ReadLine();

        Console.Write("Enter Quantity: ");
        purchase.Quantity = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Price: ");
        purchase.Price = Convert.ToDouble(Console.ReadLine());

        purchase.GenerateBill();
    }
}