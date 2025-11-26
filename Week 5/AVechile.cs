using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Week_5
{
    abstract class AVechile
    {
        public abstract void StartEngine();
        public abstract void StopEngine();

        public void Display()
        {
            Console.WriteLine("This is a vechile");
        }
    }
}
