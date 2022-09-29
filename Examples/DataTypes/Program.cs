namespace DataTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Variable: A variable is a symbolic name given to a memory location, variables are used to     store data in a computer program

            // Implicitly typed variables: Alternatively in C#, we can declare a variable without konowing   its type using var keywords. Such variables are called implicitly typed local variables.

            // Variables declared using var keyword must be initialized at the time of declaration

            // The variable name must start with either letter, underscore or @symbol.
            // ------------------------------------------------------------------------------------------
            
            // *****************************
            // ***C# Primitive Data Types***
            // *****************************
            // ***Boolean (bool)***
            // --------------------
            // 1. Boolean data types has two possible values: true or false
            // 2. Deault value: false
            // 3. Boolean variables are generally used to check conditions such as in if statements, loofs etc.
            // Example:

            bool isValid = true;
            Console.WriteLine(isValid);

            // ***Signed Integral***
            // ---------------------
            // 1. sbyte [Size: 8 bits, Range: -128 to 127, Default Value: 0]
            // Example:

            sbyte level = -128;
            Console.WriteLine(level);

            // ***Signed Integral***
            // ---------------------
            // 2. short [Size: 16 bits, Range: -32,768 to 32,767, Default Value: 0]
            // Example:

            short value = -1109;
            Console.WriteLine(value);

            // ***Signed Integral***
            // ---------------------
            // 3. int [Size: 32 bits, Range: -2147483648 to 2147483647, Default Value: 0]
            // Example:

            int score = 51902;
            Console.WriteLine(score);

            // ***Signed Integral***
            // ---------------------
            // 4. long [Size: 64 bits, Range: -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807, Default Value: 0]
            // Example:

            long range = -7091821871L;
            Console.WriteLine(range);

            // ***Unsigned Integral***
            // -----------------------
            // 1. byte [Size: 8 bits, Range: 0 to 255, Default Value: 0]
            // Example:

            byte age = 62;
            Console.WriteLine(age);

            // ***Unsigned Integral***
            // -----------------------
            // 2. ushort [Size: 16 bits, Range: 0 to 65,535, Default Value: 0]
            // Example:

            ushort value2 = 42109;
            Console.WriteLine(value2);

            // ***Unsigned Integral***
            // -----------------------
            // 3. uint [Size: 32 bits, Range: 0 to 4,294,967,295, Default Value: 0]
            // Example:

            uint totalScore = 1151092;
            Console.WriteLine(totalScore);

            // ***Unsigned Integral***
            // -----------------------
            // 3. ulong [Size: 64 bits, Range: 0 to 18,446,744,073,709,551,615, Default Value: 0]
            // Example:

            ulong range2 = 17091821871L;
            Console.WriteLine(range2);
        }
    }
}