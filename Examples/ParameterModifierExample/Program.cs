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
    }
}