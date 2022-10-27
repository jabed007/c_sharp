using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class AreaCalculator
    {
        public static string Name { get; set; }
        public static int count;

        public static double GetCircleArea(double radius)
        {
            return Math.PI * radius * radius;
        }

        public static double GetRectangleArea(double width, double height)
        {
            return width * height;
        }

        public void Print()
        {
            Console.WriteLine(Name);
        }
    }
}
