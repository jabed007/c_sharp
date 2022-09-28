namespace BasicSyntax
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // variable can have alphabet, digit or underscore and it must start with either alphabet or underscore
            const int studentAge = 23;
            string studentName = "jalaluddin";
            bool isAdmitted = true;
            double weight = 83.5;
            char initial = 'A';

            string line = Console.ReadLine();

            string[] lineParts = line.Split(' ');

            for (int i = 0; i < lineParts.Length; i++)
            {
                Console.WriteLine(lineParts[i]);
            }
        }
    }
}