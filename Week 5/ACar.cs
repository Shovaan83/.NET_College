using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Week_5
{
    class ACar : AVechile
    {
        public override void StartEngine()
        {
            Console.WriteLine("Car engine started");
        }

        public override void StopEngine()
        {
            Console.WriteLine("Car engine stopped");
        }
    }
}
