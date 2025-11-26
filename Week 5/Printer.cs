using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Week_5
{
    public class Printer
    {
        public void Print(string Message)
        {
            Console.WriteLine(Message);
        }

        public void Print(int Number)
        {
            Console.WriteLine(Number);
        }

        public void Print(string Message, int Number)
        {
            Console.WriteLine($"{Message}: {Number}");
        }
    }
}
