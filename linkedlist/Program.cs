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
                    brandName = "Mercedes",
                    engineSerial = "EN03G34939H",
                    wheelCount = 4,
                    isRegistered = false
                });
            }

            manager.AddNewVehicle(new Vehicle
            {
                brandName = "Vespa",
                engineSerial = "VSP0029939RH",
                wheelCount = 2,
                isRegistered = true
            });

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

            Console.WriteLine();
            Console.WriteLine($"Recently added vehicle: {manager.FindLatestVehicle().Value.brandName}");
            Console.WriteLine($"First vehicle: {manager.FindFirstAddedVehicle().Value.brandName}");

            Console.WriteLine();
            Vehicle vehicleByEngine = manager.FindVehicleByEngineSerial("EN03G34939H");
            Console.WriteLine($"Vehicle with the engine No EN03G34939H: {vehicleByEngine.brandName}");

        }
    }
}
