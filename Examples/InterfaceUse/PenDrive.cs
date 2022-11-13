using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceUse
{
    public class PenDrive : IUSBDevice
    {
        bool _connected;
        public bool Connect()
        {
            _connected = true;
            return _connected;
        }

        public byte[] GetData()
        {
            return UnicodeEncoding.UTF8.GetBytes("Pen Drive Data");
        }
    }
}
