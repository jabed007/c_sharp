using System.Text;

namespace StringBuilderExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string location = "Jatrabari" + ", Dhaka";
            Console.WriteLine(location);
            location += ", Bangladesh";
            Console.WriteLine(location);

            // String Builder
            StringBuilder stringBuilder = new StringBuilder(location);

            stringBuilder.Append(", South Asia");
            Console.WriteLine(stringBuilder);

            stringBuilder.Replace("a", "@");
            Console.WriteLine(stringBuilder);

            stringBuilder.Insert(40, ".");
            Console.WriteLine(stringBuilder);

            // Convert stringBuilder.ToString();
            location = stringBuilder.ToString();
            Console.WriteLine(location);

            // String Builder can be use like array
            for (int i = 0; i < location.Length; i++)
            {
                Console.WriteLine(location[i]);
            }

            // We can upadte value of string by using index number in string builder, but in general string we can not do this
            stringBuilder[0] = 'A';
        }
    }
}