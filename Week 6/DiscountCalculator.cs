using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Week_6
{
    public delegate int Calculate(int a, int b);

    public delegate double DiscountStrategy(double price);
    public class DiscountCalculator
    {
        public static int Add(int a, int b) => a + b;
        public static int Subtract(int a, int b) => a - b;

        // Discount methods
        public static double FestivalDiscount(double price) => price * 0.80;
        public static double SeasonalDiscount(double price) => price * 0.90; 
        public static double NoDiscount(double price) => price;

        public static double CalculateFinalPrice(double originalPrice, DiscountStrategy strategy)
        {
            return strategy(originalPrice);
        }
    }
}
