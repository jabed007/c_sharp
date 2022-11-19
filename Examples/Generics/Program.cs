namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Uses of object
            //Point p = new Point();
            //p.X = 10;
            //p.Y = 20.5;

            //double result = ((int)p.X) + ((double)p.Y);
        }
    }
    public class Point<T>
    {
        //public object X { get; set; }
        //public object Y { get; set; }
        public T X { get; set; }
        public T Y { get; set; }
    }
    public class FractionPoint
    {
        public double X { get; set; }
        public double Y { get; set; }
    }
}