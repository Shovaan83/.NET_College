using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Week_5
{
    class Laptop : ElectronicDevice
    {
        public Laptop(string brand, double price) : base(brand, price) { }

        public void TurnOnBattery()
        {
            Console.WriteLine("Laptop battery turned on");
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Laptop - Brand: {Brand}, Price: NPR{Price}");
        }
    }
}
