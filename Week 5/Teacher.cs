using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Week_5
{
    public class Teacher
    {
        public string Name { get; set; }

        public virtual void Teaching()
        {
            Console.WriteLine("Teacher Teaches in English");
        }

        public void SalaryInfo()
        {
            Console.WriteLine("Salary information cannot be overridden");
        }
    }
}
