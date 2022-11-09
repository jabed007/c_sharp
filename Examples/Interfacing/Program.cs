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

            //c.Open();
            c.Close();
            
            KitBox kitBox = new KitBox();
            kitBox.AddContainer(a);
            kitBox.AddContainer(new Bottle());

            //WaterBottle waterBottle = new WaterBottle();
            //waterBottle.Open();
            
            Bottle wb = new WaterBottle();
            wb.Open();
        }
    }
}