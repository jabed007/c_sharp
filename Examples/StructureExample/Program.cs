namespace StructureExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            person1.Name = "Jalal Uddin";
            Person person2 = person1;
            person2.Name = "Tareq";
            Console.WriteLine(person1.Name);
            Console.WriteLine(person2.Name);
        }
    }
}