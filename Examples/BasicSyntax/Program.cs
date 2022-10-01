namespace BasicSyntax
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /***
            Console.WriteLine("Hello World");
            // Variable can have alphabet, digit ot undrescore and it must start with either alphabet or underscore
            const int studentAge = 23;
            Console.WriteLine(studentAge);
            string studentName = "Jalal Uddin";
            Console.WriteLine(studentName);
            bool isAdmitted = true;
            Console.WriteLine(isAdmitted);
            double weight = 23.5;
            Console.WriteLine(weight);
            char initial = 'A';
            Console.WriteLine(initial);

            string line = Console.ReadLine();
            string[] lineParts = line.Split(' ');

            for (int i = 0; i < lineParts.Length; i++)
            {
                Console.WriteLine(lineParts[i]);
            }
            ***/

            // ****************************************
            // ****** C# Basic Input and Output *******
            // ****************************************

            // Example 4: Printing Concatenated String using + operator

            /***
            int val = 55;
            Console.WriteLine("Hello " + "World");
            Console.WriteLine("Value = " + val);
            ***/

            // *****************************
            // ****** C# Basic Input *******
            // *****************************

            // In C#, the simplest method to get input from the user is by using the ReadLine() Method of the Console Class. However, Read() and ReadKey() are also available for getting input from the user. They are also included in console class.

            // Example 6:Get String Input From User

            /***
            string testString;
            Console.Write("Enter a string - ");
            testString = Console.ReadLine();
            Console.WriteLine("You Entered: '{0}'", testString);
            ***/

            // Example 7: Difference between Read() and ReadKey() method
            
            int userInput;

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.WriteLine();

            Console.Write("Input using Read() - ");
            userInput = Console.Read();
            Console.WriteLine(userInput);

           
        }
    }
}