namespace Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // *****************************
            // ******** C# Operators *******
            // *****************************

            // Example 1: Basic Assignment Operator
            
            int firstNumber, secondNumber;
            // Assigning a constant to a variable
            firstNumber = 10;
            Console.WriteLine("First Number = {0}", firstNumber);

            // Assigning a variable to another variable
            secondNumber = firstNumber;
            Console.WriteLine("Second Number = {0}", secondNumber);
        }
    }
}