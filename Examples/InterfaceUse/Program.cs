namespace InterfaceUse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Laptop laptop = new Laptop();
            laptop.AddUsbDeviceInPort1(new LanCard());
            byte[] data = laptop.TransferDataFromPort1();
            Console.WriteLine(data);
        }
    }
}