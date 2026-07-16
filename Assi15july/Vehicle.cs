


namespace AutomobileVehicleManagement
{

    class Vehicle
    {
        public int VehicleID { get; set; }
        public string VehicleName { get; set; }
        public string VehicleType { get; set; }
        public string Brand { get; set; }
        public double Price { get; set; }
        public int ManufacturingYear { get; set; }
    }

    class Program
    {
        static List<Vehicle> vehicleList = new List<Vehicle>();

        static void Main(string[] args)
        {
            //--------------- User Login ----------------

            Console.Write("Enter Employee Name : ");
            string employeeName = Console.ReadLine();

            Console.Write("Enter Employee ID : ");
            int employeeId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nWelcome " + employeeName);

            int choice;

            do
            {
                Console.WriteLine("\n==============================");
                Console.WriteLine("ABC MOTORS");
                Console.WriteLine("Vehicle Management System");
                Console.WriteLine("==============================");

                Console.WriteLine("1. Add Vehicle");
                Console.WriteLine("2. View All Vehicles");
                Console.WriteLine("3. Search Vehicle");
                Console.WriteLine("4. Update Vehicle Price");
                Console.WriteLine("5. Delete Vehicle");
                Console.WriteLine("6. Calculate Discount");
                Console.WriteLine("7. Show Vehicle Details");
                Console.WriteLine("8. Exit");

                Console.Write("Enter your choice : ");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:

                        Vehicle v = new Vehicle();

                        Console.Write("Enter Vehicle ID : ");
                        v.VehicleID = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Enter Vehicle Name : ");
                        v.VehicleName = Console.ReadLine();

                        Console.Write("Enter Vehicle Type : ");
                        v.VehicleType = Console.ReadLine();

                        Console.Write("Enter Brand : ");
                        v.Brand = Console.ReadLine();

                        Console.Write("Enter Price : ");
                        v.Price = Convert.ToDouble(Console.ReadLine());

                        Console.Write("Enter Manufacturing Year : ");
                        v.ManufacturingYear = Convert.ToInt32(Console.ReadLine());

                        vehicleList.Add(v);

                        Console.WriteLine("Vehicle Added Successfully.");
                        break;

                    case 2:

                        if (vehicleList.Count == 0)
                        {
                            Console.WriteLine("No Vehicles Available.");
                        }
                        else
                        {
                            Console.WriteLine("-------------------------------------------------------------");
                            Console.WriteLine("ID\tName\tBrand\tType\tPrice");
                            Console.WriteLine("-------------------------------------------------------------");

                            foreach (Vehicle item in vehicleList)
                            {
                                Console.WriteLine(item.VehicleID + "\t" +
                                                  item.VehicleName + "\t" +
                                                  item.Brand + "\t" +
                                                  item.VehicleType + "\t" +
                                                  item.Price);
                            }
                        }

                        break;
                
                    case 3:

                        Console.Write("Enter Vehicle ID : ");
                        int searchId = Convert.ToInt32(Console.ReadLine());

                        Vehicle searchVehicle = vehicleList.Find(v => v.VehicleID == searchId);

                        if (searchVehicle != null)
                        {
                            Console.WriteLine("\nVehicle Found");
                            Console.WriteLine("Vehicle ID : " + searchVehicle.VehicleID);
                            Console.WriteLine("Vehicle Name : " + searchVehicle.VehicleName);
                            Console.WriteLine("Vehicle Type : " + searchVehicle.VehicleType);
                            Console.WriteLine("Brand : " + searchVehicle.Brand);
                            Console.WriteLine("Price : " + searchVehicle.Price);
                            Console.WriteLine("Manufacturing Year : " + searchVehicle.ManufacturingYear);
                        }
                        else
                        {
                            Console.WriteLine("Vehicle not found.");
                        }

                        break;

                    case 4:

                        Console.Write("Enter Vehicle ID : ");
                        int updateId = Convert.ToInt32(Console.ReadLine());

                        Vehicle updateVehicle = vehicleList.Find(v => v.VehicleID == updateId);

                        if (updateVehicle != null)
                        {
                            Console.Write("Enter New Price : ");
                            updateVehicle.Price = Convert.ToDouble(Console.ReadLine());

                            Console.WriteLine("Price Updated Successfully.");
                        }
                        else
                        {
                            Console.WriteLine("Vehicle ID does not exist.");
                        }

                        break;

                    case 5:

                        Console.Write("Enter Vehicle ID : ");
                        int deleteId = Convert.ToInt32(Console.ReadLine());

                        Vehicle deleteVehicle = vehicleList.Find(v => v.VehicleID == deleteId);

                        if (deleteVehicle != null)
                        {
                            vehicleList.Remove(deleteVehicle);
                            Console.WriteLine("Vehicle Deleted Successfully.");
                        }
                        else
                        {
                            Console.WriteLine("Vehicle not available.");
                        }

                        break;
                    case 6:

                        Console.Write("Enter Vehicle ID : ");
                        int discountId = Convert.ToInt32(Console.ReadLine());

                        Vehicle discountVehicle = vehicleList.Find(v => v.VehicleID == discountId);

                        if (discountVehicle != null)
                        {
                            double discount = 0;

                            if (discountVehicle.VehicleType.ToLower() == "car")
                            {
                                discount = discountVehicle.Price * 0.10;
                            }
                            else if (discountVehicle.VehicleType.ToLower() == "bike")
                            {
                                discount = discountVehicle.Price * 0.05;
                            }
                            else if (discountVehicle.VehicleType.ToLower() == "truck")
                            {
                                discount = discountVehicle.Price * 0.12;
                            }

                            Console.WriteLine("Vehicle Price : " + discountVehicle.Price);
                            Console.WriteLine("Discount : " + discount);
                            Console.WriteLine("Final Price : " + (discountVehicle.Price - discount));
                        }
                        else
                        {
                            Console.WriteLine("Vehicle not found.");
                        }

                        break;

                    case 7:

                        Console.Write("Enter Vehicle Type : ");
                        string type = Console.ReadLine().ToLower();

                        switch (type)
                        {
                            case "car":
                                Console.WriteLine("Car is a four wheeler.");
                                Console.WriteLine("Suitable for family.");
                                break;

                            case "bike":
                                Console.WriteLine("Bike is fuel efficient.");
                                Console.WriteLine("Suitable for city rides.");
                                break;

                            case "truck":
                                Console.WriteLine("Truck is used for transportation.");
                                Console.WriteLine("Heavy load vehicle.");
                                break;

                            default:
                                Console.WriteLine("Invalid Vehicle Type.");
                                break;
                        }

                        break;

                    case 8:

                        Console.WriteLine("Thank you for using ABC Motors System.");
                        break;

                    default:

                        Console.WriteLine("Invalid Choice.");
                        break;

                }

            } while (choice != 8);

        }
    }
}

