using System;

// Custom Exception
class LoginFailedException : Exception
{
    public LoginFailedException(string message) : base(message)
    {
    }
}

class Program
{
    static void Main(string[] args)
    {
        string correctUsername = "admin";
        string correctPassword = "admin123";

        int attempts = 3;

        while (attempts > 0)
        {
            Console.Write("Enter Username: ");
            string username = Console.ReadLine();

            Console.Write("Enter Password: ");
            string password = Console.ReadLine();

            if (username == correctUsername && password == correctPassword)
            {
                Console.WriteLine("\nLogin Successful");
                return;
            }
            else
            {
                attempts--;

                if (attempts == 0)
                {
                    try
                    {
                        throw new LoginFailedException("Login Failed! You have entered incorrect credentials 3 times.");
                    }
                    catch (LoginFailedException ex)
                    {
                        Console.WriteLine("\nCustom Exception: " + ex.Message);
                    }
                }
                else
                {
                    Console.WriteLine("\nInvalid Login");
                    Console.WriteLine("Attempts Left : " + attempts);
                    Console.WriteLine();
                }
            }
        }
    }
}