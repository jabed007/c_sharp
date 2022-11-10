using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClass
{
    public class Calculator
    {
        public static double PI = 3.1416;
        public int count = 0;
        public static double CalculateAverage(double[] numbers)
        {
            var sum = 0.0;

            string? name = null;

            foreach(var  number in numbers)
            {
                sum += number;
            }
            return sum / numbers.Length;
        }

        public double GetPI()
        {
            return PI;
        }
    }
}
