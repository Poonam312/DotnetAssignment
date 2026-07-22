using System;
using ShopEase.Models;
using ShopEase.Services;

namespace ShopEase
{
    class Program
    {
        static void Main(string[] args)
        {
            AuthenticationService auth = new AuthenticationService();

            while (true)
            {
                Console.WriteLine("\n====== SHOP EASE ======");
                Console.WriteLine("1. Customer Register");
                Console.WriteLine("2. Customer Login");
                Console.WriteLine("3. Admin Login");
                Console.WriteLine("4. Exit");
                Console.Write("Enter Choice : ");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        auth.Register();
                        break;

                    case 2:
                        auth.CustomerLogin();
                        break;

                    case 3:
                        auth.AdminLogin();
                        break;

                    case 4:
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            }
        }
    }
}