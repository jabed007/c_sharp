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
        }
    }
}