namespace Flow_Control
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // *********************************************************************
            // ****** C# if, if...else, if...else if and Nested if Statement *******
            // *********************************************************************

            // C# if (if-then) Statement
            // -------------------------

            // Example 1: C# if Statement

            /***
            int number = 2;
            if (number < 5)
            {
                Console.WriteLine("{0} is less than 5", number);
            }

            Console.WriteLine("This statement is always executed.");
            ***/

            // C# if...else (if-then-else) Statement
            // -------------------------------------

            // Example 2: C# if...else Statement

            /***
            int number = 12;

            if (number < 5)
            {
                Console.WriteLine("{0} is less than 5", number);
            }
            else
            {
                Console.WriteLine("{0} is greater than or equal to 5", number);
            }

            Console.WriteLine("This program is always executed");
            ***/

            // C# if...else if (if-then-else if) Statement
            // -------------------------------------------

            // Example 3: C# if...else if Statement

            /****
            int number = 12;

            if (number < 5)
            {
                Console.WriteLine("{0} is less than 5", number);
            }
            else if(number > 5)
            {
                Console.WriteLine("{0} is greater than 5", number);
            }
            else
            {
                Console.WriteLine("{0} is equal to 5", number);
            }
            ***/

            // Nested if...else Statement
            // --------------------------
            // Example 4: Nested if...else Statement
            // The following program computes the largest number among 3 numbers using nested if...else statement.

            int firstNumber = 13, secondNumber = 7, thirdNumber = -23;

            if (firstNumber > secondNumber)
            {
                if (firstNumber > thirdNumber)
                {
                    Console.WriteLine("{0} is the Largest", firstNumber);
                }
                else
                {
                    Console.WriteLine("{0} is Largest", thirdNumber);
                }
            }
            else
            {
                if (secondNumber > thirdNumber)
                {
                    Console.WriteLine("{0} is Largest", secondNumber);
                }
                else
                {
                    Console.WriteLine("{0} is Largest", thirdNumber);
                }
            }


        }
    }
}