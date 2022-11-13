using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceUse
{
    internal class Laptop
    {
        IUSBDevice? port1;
        IUSBDevice? port2;

        //public Laptop(IUSBDevice port1Device, IUSBDevice port2Device)
        //{
        //    port1 = port1Device;
        //    port2 = port2Device;
        //}
        public void AddUsbDeviceInPort1(IUSBDevice device)
        {
            port1 = device;
        }
        public void AddUsbDeviceInport2(IUSBDevice device)
        {
            port2 = device;
        }
        public byte[]? TransferDataFromPort1()
        {
            var status = port1.Connect();
            if (status)
            {
                byte[] bytes = port1.GetData();
                return bytes;
            }
            else
            {
                return null;
            }
        }
        public byte[]? TransferDataFromPort2()
        {
            var status = port2.Connect();
            if (status)
            {
                byte[] bytes = port2.GetData();
                return bytes;
            }
            else
            {
                return null;
            }
        }
    }
}
