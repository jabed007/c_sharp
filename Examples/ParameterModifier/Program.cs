namespace ParameterModifier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var result = Sum(new int[] {2, 3, 4, 5, 7, 8, 9});
            var result = Sum("Hello", 2, 3, 4, 5, 7, 8, 9);
            Console.WriteLine(result);

            var a = 10;
            var b = 20;
            TestingParameterModifier(ref a, ref b);
            Console.WriteLine($"a: {a}, b: {b}");

            TestingParameterModifier3(out a, out b);
            Console.WriteLine($"a: {a}, b: {b}");
        }
        public static int Sum(string s, params int[] nums)
        {
            var sum = 0;
            foreach(var num in nums)
            {
                sum += num;
            }
            return sum;
        }
        static void TestingParameterModifier(ref int a, ref int b)
        {
            a = 100;
            b = 200;
        }
        static void TestingParameterModifier2(in int a,in int b) // if we change or set the value of parameter in method body then it produce error
        {
            //a = 20; // Error
            //b = 30;
        }
        static void TestingParameterModifier3(out int a, out int b) // we must set the value in body when use out out parameter modifier
        {
            a = 500;
            b = 600;
        }
    }
}