using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Week_5
{
     public class NepaliTeacher : Teacher
    {
        public override void Teaching()
        {
            Console.WriteLine("Teacher Teaches in Nepali");
        }
    }
}