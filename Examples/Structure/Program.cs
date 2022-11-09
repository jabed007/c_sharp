namespace Structure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point();
            p1.X = 2;
            p1.Y = 3;

            Point p2;
            p2 = p1;

            p2.X = 5;
            p2.Y = 6;

            Console.WriteLine($"X: {p1.X}, Y: {p1.Y}");
            Console.WriteLine($"X: {p2.X}, Y: {p2.Y}");
        }
    }
}