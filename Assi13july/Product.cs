using System;
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
    static void Main(string[] args)
    {
        List<Product> products = new List<Product>();

        Console.Write("How many products do you want to add? ");
        int n = Convert.ToInt32(Console.ReadLine());

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

        Console.WriteLine("\n------ Product List ------");

        foreach (Product p in products)
        {
            Console.WriteLine("Product ID   : " + p.ProductId);
            Console.WriteLine("Product Name : " + p.ProductName);
            Console.WriteLine("Price        : " + p.Price);
            Console.WriteLine("Stock        : " + p.Stock);
            Console.WriteLine("----------------------------");
        }
    }
}