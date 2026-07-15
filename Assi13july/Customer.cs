/*using System;

class Customer
{
    public int CustomerId { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        Customer customer = new Customer();

        // Registration
        Console.WriteLine("------ Customer Registration ------");

        Console.Write("Enter Customer ID: ");
        customer.CustomerId = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Name: ");
        customer.Name = Console.ReadLine();

        Console.Write("Enter Email: ");
        customer.Email = Console.ReadLine();

        Console.Write("Enter Password: ");
        customer.Password = Console.ReadLine();

        Console.WriteLine("\nRegistration Successful");

        // Login
        Console.WriteLine("\n------ Customer Login ------");

        int attempts = 3;

        while (attempts > 0)
        {
            Console.Write("Enter Email: ");
            string email = Console.ReadLine();

            Console.Write("Enter Password: ");
            string password = Console.ReadLine();

            if (email == customer.Email && password == customer.Password)
            {
                Console.WriteLine("\nWelcome " + customer.Name);
                return;
            }
            else
            {
                attempts--;

                if (attempts > 0)
                {
                    Console.WriteLine("\nInvalid Email or Password");
                    Console.WriteLine("Attempts Left: " + attempts);
                }
                else
                {
                    Console.WriteLine("\nAccount Locked");
                }
            }
        }
    }
}
*/