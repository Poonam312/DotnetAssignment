using System.Collections.Generic;
using ShopEase.Models;

namespace ShopEase.Services
{
    public class AuthenticationService
    {
        List<Customer> customers = new List<Customer>();

        Admin admin = new Admin();

        public void Register()
        {
            Customer c = new Customer();

            Console.Write("Customer Id : ");
            c.CustomerId = Convert.ToInt32(Console.ReadLine());

            Console.Write("Name : ");
            c.Name = Console.ReadLine();

            Console.Write("Email : ");
            c.Email = Console.ReadLine();

            Console.Write("Mobile : ");
            c.Mobile = Console.ReadLine();

            Console.Write("Address : ");
            c.Address = Console.ReadLine();

            Console.Write("Username : ");
            c.Username = Console.ReadLine();

            Console.Write("Password : ");
            c.Password = Console.ReadLine();

            customers.Add(c);

            Console.WriteLine("Registration Successful");
        }

        public void CustomerLogin()
        {
            Console.Write("Username : ");
            string user = Console.ReadLine();

            Console.Write("Password : ");
            string pass = Console.ReadLine();

            foreach (Customer c in customers)
            {
                if (c.Username == user && c.Password == pass)
                {
                    Console.WriteLine("Login Successful");
                    return;
                }
            }

            Console.WriteLine("Invalid Username or Password");
        }

        public void AdminLogin()
        {
            Console.Write("Username : ");
            string user = Console.ReadLine();

            Console.Write("Password : ");
            string pass = Console.ReadLine();

            if (user == admin.Username && pass == admin.Password)
            {
                Console.WriteLine("Admin Login Successful");
            }
            else
            {
                Console.WriteLine("Invalid Admin Credentials");
            }
        }
    }
}