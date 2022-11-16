using System.Net.NetworkInformation;

namespace Enums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string y = Days.Tuesday.ToString();
            Console.WriteLine(y);
            Console.WriteLine(Days.Tuesday);
            int x = (int)Days.Tuesday;
            Console.WriteLine(x);
            Console.WriteLine(((int)Days.Tuesday));

            Days d = (Days)x;
            Console.WriteLine(d);

            Days d2 = (Days)Enum.Parse(typeof(Days), d.ToString());
            Console.WriteLine(d2);
        }
        public enum Days
        {
            Sunday = 1,
            Monday = 2,
            Tuesday = 3,
            Wednesday = 4,
        }
        public enum Weeks
        {
            FirstWeek = 1,
            SecondWeek = 2,
        }
        public static void UpdatePaymentStaus(int status)
        {
            if (status == 1)
            {

            }
            else if (status == 2)
            {

            }
        }
        public static void UpdateWeek(Days dayName)
        {
            if (dayName == Days.Sunday)
            {

            }
            else if (dayName == Days.Monday)
            {

            }
        }
    }
}