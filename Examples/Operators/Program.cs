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

            /**
            int firstNumber, secondNumber;
            // Assigning a constant to a variable
            firstNumber = 10;
            Console.WriteLine("First Number = {0}", firstNumber);

            // Assigning a variable to another variable
            secondNumber = firstNumber;
            Console.WriteLine("Second Number = {0}", secondNumber);
            **/

            // Arithmetic Operators
            // Arithmetic operators are used to perform arithmetic operations such as addition, subtraction, multiplication, division, etc.
            // Example 2: Arethmetic Operators

            double firstNumber = 14.40, secondNumber = 4.60, result;
            int num1 = 26, num2 = 4, rem;

            // Addition Operator
            result = firstNumber + secondNumber;
            Console.WriteLine("{0} + {1} = {2}", firstNumber, secondNumber, result);

            // Subtraction Operator
            result = firstNumber - secondNumber;
            Console.WriteLine("{0} - {1} = {2}", firstNumber, secondNumber, result);

            // Multiplication Operator
            result = firstNumber * secondNumber;
            Console.WriteLine("{0} * {1} = {2}", firstNumber, secondNumber, result);

            // Division Operator
            result = firstNumber / secondNumber;
            Console.WriteLine("{0} / {1} = {2}", firstNumber, secondNumber, result);

            // Modulo Operator
            rem = num1 % num2;
            Console.WriteLine("{0} % {1} = {2}", num1, num2, rem);
             
        }
    }
}