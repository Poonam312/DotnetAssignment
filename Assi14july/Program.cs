
class Program
{
    static void Main(string[] args)
    {
        int choice;

        do
        {
            Console.WriteLine("------------------------------------");
            Console.WriteLine(" Stationery Store Management System");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("1. Add Stationery Item");
            Console.WriteLine("2. Display All Items");
            Console.WriteLine("3. Search Item");
            Console.WriteLine("4. Update Item");
            Console.WriteLine("5. Delete Item");
            Console.WriteLine("6. Purchase Item");
            Console.WriteLine("7. View Low Stock Items");
            Console.WriteLine("8. Sort Items");
            Console.WriteLine("9. Exit");
            Console.Write("\nEnter Choice: ");

            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("\nAdd Stationery Item Selected\n");
                    break;

                case 2:
                    Console.WriteLine("\nDisplay All Items Selected\n");
                    break;

                case 3:
                    Console.WriteLine("\nSearch Item Selected\n");
                    break;

                case 4:
                    Console.WriteLine("\nUpdate Item Selected\n");
                    break;

                case 5:
                    Console.WriteLine("\nDelete Item Selected\n");
                    break;

                case 6:
                    Console.WriteLine("\nPurchase Item Selected\n");
                    break;

                case 7:
                    Console.WriteLine("\nView Low Stock Items Selected\n");
                    break;

                case 8:
                    Console.WriteLine("\nSort Items Selected\n");
                    break;

                case 9:
                    Console.WriteLine("\nThank You! Exiting...");
                    break;

                default:
                    Console.WriteLine("\nInvalid Choice!\n");
                    break;
            }

        } while (choice != 9);
    }
}