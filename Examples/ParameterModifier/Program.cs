namespace ParameterModifier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var result = Sum(new int[] {2, 3, 4, 5, 7, 8, 9});
            var result = Sum("Hello", 2, 3, 4, 5, 7, 8, 9);
            Console.WriteLine(result);
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
        static void TestingParameterModifier(int a, int b)
        {

        }
    }
}