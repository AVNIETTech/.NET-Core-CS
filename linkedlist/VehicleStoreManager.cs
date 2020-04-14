using System;
using System.Collections.Generic;

namespace linkedlist
{
    public class VehicleStoreManager
    {
        private LinkedList<Vehicle> vehicleList;

        public bool CreateNewVehicleList()
        {
            vehicleList = new LinkedList<Vehicle>();
            return vehicleList != null;
        }
        public bool CreateNewVehicleListFromData(Vehicle[] vehicles)
        {
            vehicleList = new LinkedList<Vehicle>(vehicles);
            return vehicleList != null;
        }

        public void AddNewVehicle(Vehicle vehicle)
        {
            LinkedListNode<Vehicle> newVehicleNode = new LinkedListNode<Vehicle>(vehicle);
            vehicleList.AddFirst(newVehicleNode);
        }

        public LinkedList<Vehicle> GetVehiclesList()
        {
            return vehicleList;
        }

        public LinkedListNode<Vehicle> FindLatestVehicle()
        {
            return vehicleList.First;
        }

        public LinkedListNode<Vehicle> FindFirstAddedVehicle()
        {
            return vehicleList.Last;
        }

        public Vehicle FindVehicleByEngineSerial(string engineSerial)
        {
            foreach(Vehicle vehicle in vehicleList)
            {
                if(vehicle.engineSerial.Equals(engineSerial))
                {
                    return vehicle;
                }
            }
            return null;
        }
    }
}