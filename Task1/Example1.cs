class Example1
{
    static void Main()
    {
        int totalPackages = 0;
        int qualityCheck = 0;
        int priorityShipment = 0;
        int normalPackages = 0;

        for (int packageID = 1001; packageID <= 1020; packageID++)
        {
            totalPackages++;

            if (packageID % 4 == 0)
            {
                Console.WriteLine(packageID + " - Quality Check Required");
                qualityCheck++;
            }
            else if (packageID % 5 == 0)
            {
                Console.WriteLine(packageID + " - Priority Shipment");
                priorityShipment++;
            }
            else
            {
                Console.WriteLine(packageID + " - Normal Processing");
                normalPackages++;
            }
        }

        Console.WriteLine("Total Packages Processed : " + totalPackages);
        Console.WriteLine("Quality Check Required : " + qualityCheck);
        Console.WriteLine("Priority Shipments : " + priorityShipment);
        Console.WriteLine("Normal Packages : " + normalPackages);
    }
}