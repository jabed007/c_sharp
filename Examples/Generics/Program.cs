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

            // Uses of Generics class
            Point<double> p = new Point<double>();
            p.X = 10.5;
            p.Y = 20.5;

            var result = p.X + p.Y;
            Console.WriteLine(result);

            Point2<int, double> p2 = new Point2<int, double>();
            p2.X = 100;
            p2.Y = 200.50;

            Tree<string> tree = new Tree<string>();
            tree.AddNode("ABC");
            tree.AddNode("XYZ");

            string item = tree.RemoveNode("XYZ");
            Console.WriteLine(item);
        }
    }

    // Generics Class
    public class Point<T> where T:struct // Single Parameterized Generics class
    {
        //public object X { get; set; }
        //public object Y { get; set; }
        public T X { get; set; }
        public T Y { get; set; }
    }

    public class Point2<T, D> where T:class, new() where D:struct // Multiple Parameterized Generics class
    {
        public T X { get; set; }
        public D Y { get; set; }

        //public S Sum()
        //{
        //    return X + Y; // error
        //}
    }

    public interface Isumable
    {
        public string Sum(string a, string b);
    }

    public class Graph<T>
    {

    }

    public class Tree<T>
    {
        private T[] nodes;
        private int index = 0;
        public void AddNode(T node)
        {
            nodes[index++] = node;
        }

        public T RemoveNode(T node)
        {
            T currentItem = nodes[--index];
            nodes[index] = default(T);
            return currentItem;
        }
    }

    public class FractionPoint // Normal class
    {
        public double X { get; set; }
        public double Y { get; set; }
    }

    // Generics Method
    public static class Printer<X>
    {
        public static void Print<T>(T item) where T : struct
        {
            T x = default(T);
            X a = default(X);
            Console.WriteLine(item);
        }

        public static void Revert()
        {
            T t = default(T); // error
            X x = default(X);
        }
    }
}