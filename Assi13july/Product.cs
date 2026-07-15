using System.Collections.Generic;

class Product
{
    public int ProductId { get; set; }
    public string ProductName { get; set; }
    public double Price { get; set; }
    public int Stock { get; set; }
}

class Program
{
    static void Main()
    {
        List<Product> products = new List<Product>();

        Console.Write("How many products do you want to add? ");
        int n = Convert.ToInt32(Console.ReadLine());

        // Add Products
        for (int i = 0; i < n; i++)
        {
            Product p = new Product();

            Console.WriteLine($"\nEnter Details of Product {i + 1}");

            Console.Write("Enter Product ID: ");
            p.ProductId = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Product Name: ");
            p.ProductName = Console.ReadLine();

            Console.Write("Enter Price: ");
            p.Price = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Stock: ");
            p.Stock = Convert.ToInt32(Console.ReadLine());

            products.Add(p);
        }

        // Display Products
        Console.WriteLine("\n------ Product List ------");

        foreach (Product p in products)
        {
            Console.WriteLine("-----------------------");
            Console.WriteLine("Product ID   : " + p.ProductId);
            Console.WriteLine("Product Name : " + p.ProductName);
            Console.WriteLine("Price        : " + p.Price);
            Console.WriteLine("Stock        : " + p.Stock);
        }

        // Search Product
        Console.Write("\nEnter Product Name to Search: ");
        string searchName = Console.ReadLine();

        bool found = false;

        foreach (Product p in products)
        {
            if (p.ProductName.Equals(searchName, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("\nProduct Found");
                Console.WriteLine("Product ID   : " + p.ProductId);
                Console.WriteLine("Product Name : " + p.ProductName);
                Console.WriteLine("Price        : " + p.Price);
                Console.WriteLine("Stock        : " + p.Stock);

                found = true;
                break;
            }
        }

        if (!found)
        {
            Console.WriteLine("Product Not Found");
        }

        // PART 2 STARTS FROM HERE...
    }
}// List to store cart items
List<string> cart = new List<string>();

double totalAmount = 0;

int choice;

do
{
    Console.WriteLine("\n------ Available Products ------");

    foreach (Product p in products)
    {
        Console.WriteLine(p.ProductId + "  " + p.ProductName + "  Price: " + p.Price + "  Stock: " + p.Stock);
    }

    Console.Write("\nEnter Product ID: ");
    int id = Convert.ToInt32(Console.ReadLine());

    Console.Write("Enter Quantity: ");
    int qty = Convert.ToInt32(Console.ReadLine());

    bool productFound = false;

    foreach (Product p in products)
    {
        if (p.ProductId == id)
        {
            productFound = true;

            if (p.Stock >= qty)
            {
                p.Stock = p.Stock - qty;

                cart.Add(p.ProductName + " x" + qty);

                totalAmount = totalAmount + (p.Price * qty);

                Console.WriteLine("Product Added to Cart");
            }
            else
            {
                Console.WriteLine("Stock Not Available");
            }

            break;
        }
    }

    if (!productFound)
    {
        Console.WriteLine("Product Not Found");
    }

    Console.WriteLine("\nDo you want to add another product?");
    Console.WriteLine("1. Yes");
    Console.WriteLine("2. No");

    choice = Convert.ToInt32(Console.ReadLine());

} while (choice == 1);


// Display Cart
Console.WriteLine("\n------ CART ------");

foreach (string item in cart)
{
    Console.WriteLine(item);
}


// Apply Discount
double discount = 0;

if (totalAmount >= 10000)
{
    discount = totalAmount * 0.30;
}
else if (totalAmount >= 5000)
{
    discount = totalAmount * 0.20;
}
else if (totalAmount >= 1000)
{
    discount = totalAmount * 0.10;
}
else
{
    discount = 0;
}

double finalAmount = totalAmount - discount;


// Final Bill
Console.WriteLine("\n------ BILL ------");
Console.WriteLine("Total Amount : " + totalAmount);
Console.WriteLine("Discount : " + discount);
Console.WriteLine("Final Amount : " + finalAmount);