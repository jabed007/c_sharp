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

            Printer<int>.Print<double>(5.5);

            #region Built in C# Generics

            // List
            List<int> list = new List<int>();
            list.Add(1);
            list[0] = 2;

            // Dictionary
            // Dictionary is a key value pair generics that means it take two parameter in generics
            // 1. Key 2. Value
            Dictionary<string, double> weights = new Dictionary<string, double>();
            weights["Jalal Uddin"] = 87.5;
            weights["Tareq"] = 78.5;

            Dictionary<Item, double> items = new Dictionary<Item, double>();
            Item key = new Item();
            items[key] = 33.5;
            double back = items[key];

            // Stack
            Stack<int> stack = new Stack<int>();
            stack.Push(3);
            stack.Push(5);
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Count);
            Console.WriteLine(stack.Peek());

            // Queue
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            Console.WriteLine(queue.Dequeue());

            // Sorted List
            SortedList<string, int> ages = new SortedList<string, int>();
            ages["Tareq"] = 64;
            ages["Jalal Uddin"] = 58;
            ages["Ahmed"] = 99;
            ages["Tareq"] = 43;

            foreach(var i in ages)
            {
                Console.WriteLine($"Key: {i.Key}, Value: {i.Value}");
            }

            // Soretd Dictionary
            SortedDictionary<string, int> ages2  = new SortedDictionary<string, int>();
            ages2["Tareq"] = 64;
            ages2["Jalal Uddin"] = 58;
            ages2["Ahmed"] = 99;
            ages2["Tareq"] = 43;

            #endregion

            #region Non Generic Collection

            #endregion

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

    public class Point2<T, D> where T:struct where D:struct // Multiple Parameterized Generics class
    {
        public T X { get; set; }
        public D Y { get; set; }

        //public S Sum()
        //{
        //    return X + Y; // error
        //}
    }

    public class Item
    {
        public int X { get; set; }
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
        private T[] nodes = new T[100];
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
            //T t = default(T); // error
            X x = default(X);
        }
    }
}