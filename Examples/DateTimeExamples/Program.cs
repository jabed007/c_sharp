using Microsoft.VisualBasic;

namespace DateTimeExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime date = new DateTime();
            Console.WriteLine(date);

            DateTime date1 = new DateTime(2002, 4, 23, 10, 15, 30);
            Console.WriteLine(date1);

            DateTime date2 = new DateTime(2022, 11, 17, 13, 20, 50);
            Console.WriteLine(date2);
            Console.WriteLine(date2.ToString("dd-MM-yy"));

            date2 = date2.AddMonths(2);
            Console.WriteLine(date2);

            DateTime date3 = DateTime.Now;
            Console.WriteLine(date3);
            Console.WriteLine(date3.DayOfYear);
            Console.WriteLine(date3.DayOfWeek);

            DateTime date4 = DateTime.UtcNow;
            Console.WriteLine(date4);

            double totalDays = date4.Subtract(date1).TotalDays;
            Console.WriteLine(totalDays);
        }
    }
}