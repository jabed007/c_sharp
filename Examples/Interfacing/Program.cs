namespace Interfacing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IContainer a = new Bottle();
            IColorable b = new Bottle();
            IClosable c = new Bottle();

            var capacity = a.Capacity;

            a.AddContent(5);
            a.RemoveContent(3);

            var color = b.Color;

            c.Open();
            c.Close();  
        }
    }
}