namespace StaticClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var result = Calculator.CalculateAverage(new double[] {2.3, 3.4});
            Console.WriteLine(result);

            Console.WriteLine(Calculator.PI);

            Calculator calculator = new Calculator();
            calculator.count = 5;

            Calculator calculator2 = new Calculator();
            calculator2.count = 9;

            Calculator.PI = 4.9;

            Console.WriteLine(calculator.GetPI());
            Console.WriteLine(calculator2.GetPI());
        }
    }
}