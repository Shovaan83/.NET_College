using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Week_5
{
    class ElectronicStore
    {
        private List<ElectronicDevice> devices = new List<ElectronicDevice>();

        public void AddDevice(ElectronicDevice device)
        {
            devices.Add(device);
            Console.WriteLine($"{device.Brand} added to store");
        }

        public void RemoveDevice(ElectronicDevice device)
        {
            devices.Remove(device);
            Console.WriteLine($"{device.Brand} removed from store");
        }

        public void ShowAllDeviceDetails()
        {
            Console.WriteLine("\n All Devices in Store");
            foreach (var device in devices)
            {
                device.ShowInfo();

                if (device is Laptop)
                {
                    ((Laptop)device).TurnOnBattery();
                }
                else if (device is Smartphone)
                {
                    ((Smartphone)device).EnableCamera();
                }
                Console.WriteLine();
            }
        }
    }
}
