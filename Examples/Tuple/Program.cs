namespace Tuple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] result = new int[100, 100];

            int count = 0;

            //Point[] points = new Point[100];
            // Tuple
            (int x, int y)[] points = new (int x, int y)[100];

            for (int i = 1; i < 100; i++)
            {
                for (int j = 1; j < 100; j++)
                {
                    points[count++] = new(int x, int y);
                }
            }

            int r = 0;

            for (int i = 0; i < count; i++)
            {
                r += points[i].x * points[i].y + points[i].x / points[i].y;
            }

            (string[] data, int count) myData = GetData();
            Console.WriteLine(myData.count);
            foreach(var item in myData.data)
            {
                Console.WriteLine(item);
            }
        }

        // Tuple as a return type
        public static (string[] data, int count) GetData()
        {
            string[] r = new string[] {"Hello", "Dhaka"};
            int c = 20;
            return(r, c);
        }

        //public struct Point
        //{
        //    public int x;
        //    public int y;
        //}
    }
}