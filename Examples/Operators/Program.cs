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
            

            // *****************************
            // **** Arithmetic Operator ****
            // *****************************

            // Arithmetic operators are used to perform arithmetic operations such as addition, subtraction, multiplication, division, etc.
            // Example 2: Arethmetic Operators

            
            double firstNumberD = 14.40, secondNumberD = 4.60, result;
            int num1 = 26, num2 = 4, rem;

            // Addition Operator
            result = firstNumberD + secondNumberD;
            Console.WriteLine("{0} + {1} = {2}", firstNumberD, secondNumberD, result);

            // Subtraction Operator
            result = firstNumberD - secondNumberD;
            Console.WriteLine("{0} - {1} = {2}", firstNumberD, secondNumberD, result);

            // Multiplication Operator
            result = firstNumberD * secondNumberD;
            Console.WriteLine("{0} * {1} = {2}", firstNumberD, secondNumberD, result);

            // Division Operator
            result = firstNumberD / secondNumberD;
            Console.WriteLine("{0} / {1} = {2}", firstNumberD, secondNumberD, result);

            // Modulo Operator
            rem = num1 % num2;
            Console.WriteLine("{0} % {1} = {2}", num1, num2, rem);
            

            // *****************************
            // **** Relational Operator ****
            // *****************************

            // Example 3: Relational Operators

            
            bool resultR;
            int firstNumberR = 10, secondNumberR = 20;

            resultR = (firstNumberR == secondNumberR);
            Console.WriteLine("{0} == {1} returns {2}", firstNumberR, secondNumberR, resultR);

            resultR = (firstNumberR > secondNumberR);
            Console.WriteLine("{0} > {1} returns {2}", firstNumberR, secondNumberR, resultR);

            resultR = (firstNumberR < secondNumberR);
            Console.WriteLine("{0} < {1} returns {2}", firstNumberR, secondNumberR, resultR);

            resultR = (firstNumberR >= secondNumberR);
            Console.WriteLine("{0} >= {1} returns {2}", firstNumberR, secondNumberR, resultR);

            resultR = (firstNumberR <= secondNumberR);
            Console.WriteLine("{0} <= {1} returns {2}", firstNumberR, secondNumberR, resultR);

            resultR = (firstNumberR != secondNumberR);
            Console.WriteLine("{0} != {1} returns {2}", firstNumberR, secondNumberR, resultR);
           

            // *****************************
            // ****** Logical Operator *****
            // *****************************

            // Example 4: Logical Operators

           
            bool resultL;
            int firstNumberL = 10, secondNumberL = 20;

            // OR Operator
            resultL = (firstNumberL == secondNumberL) || (firstNumberL > 5);
            Console.WriteLine(resultL);

            // AND Operator
            resultL = (firstNumberL == secondNumberL) && (firstNumberL > 5);
            Console.WriteLine(resultL);
            

            // *****************************
            // ****** Unary Operator *******
            // *****************************

            // Example 5: Unary Operator

            
            int numberUn = 10, resultUn;
            bool flag = true;

            resultUn = +numberUn;
            Console.WriteLine("+numberUn = " + resultUn);

            resultUn = -numberUn;
            Console.WriteLine("-numberUn = " + resultUn);

            resultUn = ++numberUn;
            Console.WriteLine("++numberUn = " + resultUn);

            resultUn = --numberUn;
            Console.WriteLine("--numberUn = " + resultUn);

            Console.WriteLine("!flag = " + (!flag));

            // Example 6: Post and Pre Increment operators in C#

            Console.WriteLine(numberUn++);
            Console.WriteLine(numberUn);

            Console.WriteLine(++numberUn);
            Console.WriteLine(numberUn);
            

            // *****************************
            // ****** Ternary Operator *****
            // *****************************

            // The ternary operator -- ? : -- operates on three operands. It is a shorthand for if-then-else statement. Ternary operator can be used as follows 
            // variable = condition? Expression1 : Expression2;
            // The ternary operator work as follows:
            // If the expression stated by Condition is true, the result of Expression1 is assigned to variable
            // If it is false, the result of Expression2 is assigned to variable.

            // Example 7: Ternary Operator

            
            int numberT = 10;
            string resultT;

            resultT = (numberT % 2 == 0) ? "Even number" : "Odd Number";

            Console.WriteLine("{0} is {1}", numberT, resultT);

            // ********************************************
            // ****** Bitwise and Bit Shift Operators *****
            // ********************************************

            // Bitwise and Bit Shift Operators are used to perform bit manifulation operations

            // Example 8: Bitwise and Bit Shift Operator

            int firstNumberB = 10;
            int secondNumberB = 20;
            int resultB;

            resultB = ~firstNumberB;
            Console.WriteLine("~{0} = {1}", firstNumberB, resultB);

            result = (firstNumberB & secondNumberB);
            Console.WriteLine("{0} & {1} = {2}", firstNumberB, secondNumberB, resultB);

            resultB = (firstNumberB | secondNumberB);
            Console.WriteLine("{0} | {1} = {2}", firstNumberB, secondNumberB, resultB);

            resultB = (firstNumberB ^ secondNumberB);
            Console.WriteLine("{0} ^ {1} = {2}", firstNumberB, secondNumberB, resultB);

            resultB = firstNumberB << 2;
            Console.WriteLine("{0} << 2 = {1}", firstNumberB, resultB);

            resultB = firstNumberB >> 2;
            Console.WriteLine("{0} >> 2 = {1}", firstNumberB, resultB);

            // ********************************************
            // ****** Compound Assignment Operators *******
            // ********************************************

            // Example 9: Compound Assignment Operator


            int numberC = 10;

            numberC += 5;
            Console.WriteLine(numberC);

            numberC -= 3;
            Console.WriteLine(numberC);

            numberC *= 2;
            Console.WriteLine(numberC);

            numberC /= 3;
            Console.WriteLine(numberC);

            numberC %= 3;
            Console.WriteLine(numberC);

            numberC &= 10;
            Console.WriteLine(numberC);

            numberC |= 14;
            Console.WriteLine(numberC);

            numberC ^= 12;
            Console.WriteLine(numberC);

            numberC <<= 2;
            Console.WriteLine(numberC);

            numberC >>= 3;
            Console.WriteLine(numberC);

            // **************************************
            // ****** C# Operator By DevSkill *******
            // **************************************

            int i = 3;
            Console.WriteLine(i); // output: 3
            Console.WriteLine(i++); // output: 3
            Console.WriteLine(i); // output: 4

            double aa = 1.5;
            Console.WriteLine(aa); // output: 1.5
            Console.WriteLine(++aa); // output: 2.5
            Console.WriteLine(aa); // output: 2.5

            int i2 = 3;
            Console.WriteLine(i2); // output: 3
            Console.WriteLine(i2--); // output: 3
            Console.WriteLine(i2); // output: 2

            double aa2 = 1.5;
            Console.WriteLine(aa2); // output 1.5
            Console.WriteLine(--aa2); // output 0.5
            Console.WriteLine(aa2); // output 0.5

            // Unary plus and minus operators
            Console.WriteLine(+4); 	// output: 4
            Console.WriteLine(-4); 	// output: -4
            Console.WriteLine(-(-4));  // output: 4

            // Math operators
            Console.WriteLine(5 * 2); // output: 10
            Console.WriteLine(0.5 * 2.5); // output: 1.25
            Console.WriteLine(0.1m * 23.4m); // output: 2.34
            Console.WriteLine(13 / 5);  // output: 2
            Console.WriteLine(-13 / 5);   // output: -2
            Console.WriteLine(13 / -5);   // output: -2
            Console.WriteLine(-13 / -5);  // output: 2

            Console.WriteLine(16.8f / 4.1f);   // output: 4.097561
            Console.WriteLine(16.8d / 4.1d);   // output: 4.09756097560976
            Console.WriteLine(16.8m / 4.1m);   // output: 4.09756097560975609756097560

            Console.WriteLine(5 % 4);   // output: 1
            Console.WriteLine(5 % -4);  // output: 1
            Console.WriteLine(-5 % 4);  // output: -1
            Console.WriteLine(-5 % -4); // output: -1

            Console.WriteLine(-5.2f % 2.0f); // output: -1.2
            Console.WriteLine(5.9 % 3.1);   // output: 2.8
            Console.WriteLine(5.9m % 3.1m);  // output: 2.8

            Console.WriteLine(5 + 4);       // output: 9
            Console.WriteLine(5 + 4.3);     // output: 9.3
            Console.WriteLine(5.1m + 4.2m); // output: 9.3

            Console.WriteLine(47 - 3);      // output: 44
            Console.WriteLine(5 - 4.3);     // output: 0.7
            Console.WriteLine(7.5m - 2.3m); // output: 5.2

            int x = 5;
            x += 9;
            Console.WriteLine(x);  // output: 14

            x -= 4;
            Console.WriteLine(x);  // output: 10

            x *= 2;
            Console.WriteLine(x);  // output: 20

            x /= 4;
            Console.WriteLine(x);  // output: 5

            x %= 3;
            Console.WriteLine(x);  // output: 2

            // Bitwise complement operator

            uint t = 0b_00;

        }
    }
}