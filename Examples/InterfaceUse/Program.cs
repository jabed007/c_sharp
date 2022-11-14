namespace InterfaceUse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Laptop laptop = new Laptop();
            laptop.AddUsbDeviceInPort1(new LanCard());
            var data = laptop.TransferDataFromPort1();
            Console.WriteLine(data);

            HoverCraft hoverCraft = new HoverCraft();
            hoverCraft.StartEngine();

            ICar hoverCraft2 = new HoverCraft();
            hoverCraft2.StopEngine();

            ClassB classB = new ClassB();
            classB.Method1();
            classB.Method2();
            classB.Method3();
            classB.Method4();

            ClassA classA = new ClassA();
            classA.Method1();
            classA.Method2();

            ClassA classB2 = new ClassB(); // boxing
            classB2.Method1();
            classB2.Method2();

            ClassB classB3 = (ClassB)classB2; // unboxing
        }
    }
}