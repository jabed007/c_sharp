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

            /***
            int firstNumber, secondNumber;
            // Assigning a constant to a variable
            firstNumber = 10;
            Console.WriteLine("First Number = {0}", firstNumber);

            // Assigning a variable to another variable
            secondNumber = firstNumber;
            Console.WriteLine("Second Number = {0}", secondNumber);
            ***/

            // *****************************
            // **** Arithmetic Operator ****
            // *****************************

            // Arithmetic operators are used to perform arithmetic operations such as addition, subtraction, multiplication, division, etc.
            // Example 2: Arethmetic Operators

            /***
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
            ***/

            // *****************************
            // **** Relational Operator ****
            // *****************************

            // Example 3: Relational Operators

            /***
            bool result;
            int firstNumber = 10, secondNumber = 20;

            result = (firstNumber == secondNumber);
            Console.WriteLine("{0} == {1} returns {2}", firstNumber, secondNumber, result);

            result = (firstNumber > secondNumber);
            Console.WriteLine("{0} > {1} returns {2}", firstNumber, secondNumber, result);

            result = (firstNumber < secondNumber);
            Console.WriteLine("{0} < {1} returns {2}", firstNumber, secondNumber, result);

            result = (firstNumber >= secondNumber);
            Console.WriteLine("{0} >= {1} returns {2}", firstNumber, secondNumber, result);

            result = (firstNumber <= secondNumber);
            Console.WriteLine("{0} <= {1} returns {2}", firstNumber, secondNumber, result);

            result = (firstNumber != secondNumber);
            Console.WriteLine("{0} != {1} returns {2}", firstNumber, secondNumber, result);
            ***/

            // *****************************
            // ****** Logical Operator *****
            // *****************************

            // Example 4: Logical Operators

            bool result;
            int firstNumber = 10, secondNumber = 20;

            result = (firstNumber == secondNumber) || (firstNumber > 5);
            Console.WriteLine(result);

            result = (firstNumber == secondNumber) && (firstNumber > 5);
            Console.WriteLine(result);

        }
    }
}