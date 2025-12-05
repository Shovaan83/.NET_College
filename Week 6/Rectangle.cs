using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Week_6
{
    public class Rectangle
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public double Area => Width * Height;

        public double GetPerimeter() => 2 * (Width + Height);

        public override string ToString() => $"Rectangle: {Width}x{Height}, Area: {Area}, Perimeter: {GetPerimeter()}";
    }
}
