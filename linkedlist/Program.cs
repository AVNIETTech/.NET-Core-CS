using System;

namespace linkedlist
{
    class Program
    {
        static void Main(string[] args)
        {
            ManageVehicles();
        }

        static void ManageVehicles()
        {
            VehicleStoreManager manager = new VehicleStoreManager();
            if (manager.CreateNewVehicleList())
            {
                manager.AddNewVehicle(new Vehicle
                {
                    brandName = "Mercedez",
                    engineSerial = "EN03G34939H",
                    wheelCount = 4,
                    isRegistered = false
                });
            }

            int i = 0;
            foreach (Vehicle vehicle in manager.GetVehiclesList())
            {
                Console.WriteLine($"Vehicle {i+1}");
                Console.WriteLine($"Brand: {vehicle.brandName}");
                Console.WriteLine($"Engine Serial No: {vehicle.engineSerial}");
                Console.WriteLine($"Wheel count: {vehicle.wheelCount}");
                Console.WriteLine($"The vehicle is registered?: {vehicle.isRegistered}");
                Console.WriteLine();
                i += 1;
            }
        }
    }
}
