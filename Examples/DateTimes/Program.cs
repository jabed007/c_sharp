namespace DateTimes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime today = new DateTime(2021, 8, 26);
            Console.WriteLine(today);

            DateTime now = new DateTime(2021, 8, 26, 21, 25, 00);
            Console.WriteLine(now);

            DateTime currentDateTime = DateTime.Now;
            Console.WriteLine(currentDateTime);

            DateTime parsedDate = DateTime.Parse("17/11/2022");
            Console.WriteLine(parsedDate);

            Console.WriteLine(now.ToLongTimeString());
            Console.WriteLine(now.ToString());
            Console.WriteLine(now.AddYears(2));
            Console.WriteLine(now.DayOfYear);
        }
    }
}