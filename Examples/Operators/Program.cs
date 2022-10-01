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

            /***
            bool result;
            int firstNumber = 10, secondNumber = 20;

            // OR Operator
            result = (firstNumber == secondNumber) || (firstNumber > 5);
            Console.WriteLine(result);

            // AND Operator
            result = (firstNumber == secondNumber) && (firstNumber > 5);
            Console.WriteLine(result);
            ***/

            // *****************************
            // ****** Unary Operator *******
            // *****************************

            // Example 5: Unary Operator

            /***
            int number = 10, result;
            bool flag = true;

            result = +number;
            Console.WriteLine("+number = " + result);

            result = -number;
            Console.WriteLine("-number = " + result);

            result = ++number;
            Console.WriteLine("++number = " + result);

            result = --number;
            Console.WriteLine("--number = " + result);

            Console.WriteLine("!flag = " + (!flag));

            // Example 6: Post and Pre Increment operators in C#

            Console.WriteLine(number++);
            Console.WriteLine(number);

            Console.WriteLine(++number);
            Console.WriteLine(number);
            ***/

            // *****************************
            // ****** Ternary Operator *****
            // *****************************

            // The ternary operator -- ? : -- operates on three operands. It is a shorthand for if-then-else statement. Ternary operator can be used as follows 
            // variable = condition? Expression1 : Expression2;
            // The ternary operator work as follows:
            // If the expression stated by Condition is true, the result of Expression1 is assigned to variable
            // If it is false, the result of Expression2 is assigned to variable.

            // Example 7: Ternary Operator

            /***
            int number = 10;
            string result;

            result = (number % 2 == 0) ? "Even number" : "Odd Number";

            Console.WriteLine("{0} is {1}", number, result);
            ***/

            // ********************************************
            // ****** Bitwise and Bit Shift Operators *****
            // ********************************************

            // Bitwise and Bit Shift Operators are used to perform bit manifulation operations

            // Example 8: Bitwise and Bit Shift Operator

            int firstNumber = 10;
            int secondNumber = 20;
            int result;

            result = ~firstNumber;
            Console.WriteLine("~{0} = {1}", firstNumber, result);

            result = (firstNumber & secondNumber);
            Console.WriteLine("{0} & {1} = {2}", firstNumber, secondNumber, result);

            result = (firstNumber | secondNumber);
            Console.WriteLine("{0} | {1} = {2}", firstNumber, secondNumber, result);

            result = (firstNumber ^ secondNumber);
            Console.WriteLine("{0} ^ {1} = {2}", firstNumber, secondNumber, result);

            result = firstNumber << 2;
            Console.WriteLine("{0} << 2 = {1}", firstNumber, result);

            result = firstNumber >> 2;
            Console.WriteLine("{0} >> 2 = {1}", firstNumber, result);
        }
    }
}