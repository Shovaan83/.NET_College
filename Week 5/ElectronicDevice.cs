using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Week_5
{
    abstract class ElectronicDevice
    {

        public ElectronicDevice(string brand, double price)
        {
            Brand = brand;
            Price = price;
        }

        public string Brand { get; set; }


        public double Price { get; set; }


        public abstract void ShowInfo();
    }
}
