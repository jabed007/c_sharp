using System.Text;

namespace StringBuilders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder stringBuilder = new StringBuilder();
            while(true)
            {
                var word = Console.ReadLine();
                if (word == "exit")
                {
                    break;
                }
                else
                {
                    stringBuilder.Append("<p>").Append(word).AppendLine("</p>");
                }
            }
            Console.WriteLine(stringBuilder);
        }
    }
}