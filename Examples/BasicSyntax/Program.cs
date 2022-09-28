namespace BasicSyntax
{
    internal class Program
    {
        static void Main(string[] args)
        {
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
        }
    }
}