namespace NullableAndAnonymus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int? x = null;
            x = 6;

            string? s = null;

            if (x == null)
            {
                Console.WriteLine("x is null");
            }

            Console.WriteLine(x.HasValue);
            Console.WriteLine(x.Value);

            Print(x.Value);

            // Anonymus type
            //Object person = new { name = "Md. Jabed Hossain", age = 28, address = "Dhaka"};
            dynamic person = new { name = "Md. Jabed Hossain", age = 28, address = "Dhaka" }; // anonymus object
            Console.WriteLine(person.name);
        }

        static void Print(int n)
        {
            Console.WriteLine(n);
        }
    }
}