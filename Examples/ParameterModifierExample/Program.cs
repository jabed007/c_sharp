namespace ParameterModifierExample
{
    public class Program
    {
        static void Main(string[] args)
        {
            double r1 = CalculateAverage(10, 20);
            double r2 = CalculateAverage(10, 20, 30);

            // Uses of params keyword
            //double average = CalculateAverage(new double[] {1, 2, 3, 4});
            //Console.WriteLine(average);

            var average = CalculateAverage(1, 2, 3, 4, 5);
            Console.WriteLine(average);
        }
        public static double CalculateAverage(double x, double y)
        {
            return (x + y) / 2;
        }

        public static double CalculateAverage(double x, double y, double z)
        {
            return (x + y + z) / 3;
        }

        public static double CalculateAverage(params double[] numbers)
        {
            var sum = 0.0;
            foreach (var number in numbers)
            {
                sum += number;
            }
            
            return sum / numbers.Length;
        }

        public static void UpdateValue1(in double value)
        {
            // We can only receive value but cant modify thats mean we cant change the value of the value paramter
            //value = 1000; // error
        }

        public static void UpdateValue2(out double value)
        {
            // When we use out parameter modifier we must changes the value of the paramter variable
            value = 100;
        }

        public static void UpdateValue3(ref double value)
        {
            // When we use ref we can either change or modify the paramter or not modify the paramter
        }
    }
}