
using System;

class Payment
{
    static void Main()
    {
        Console.WriteLine("Choose Payment");
        Console.WriteLine("1. UPI");
        Console.WriteLine("2. Credit Card");
        Console.WriteLine("3. Debit Card");
        Console.WriteLine("4. Cash on Delivery");

        Console.Write("Enter your choice: ");
        int choice = Convert.ToInt32(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Console.WriteLine("Payment Successful using UPI");
                break;

            case 2:
                Console.WriteLine("Payment Successful using Credit Card");
                break;

            case 3:
                Console.WriteLine("Payment Successful using Debit Card");
                break;

            case 4:
                Console.WriteLine("Payment Successful using Cash on Delivery");
                break;

            default:
                Console.WriteLine("Invalid Option");
                break;
        }
    }
}