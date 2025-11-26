using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Week_5
{
    class Smartphone : ElectronicDevice
    {
        public Smartphone(string brand, double price) : base(brand, price) { }

        public void EnableCamera()
        {
            Console.WriteLine("Smartphone camera enabled");
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Smartphone - Brand: {Brand}, Price: NPR{Price}");
        }
    }
}
