using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceUse
{
    internal interface IUSBDevice
    {
        public bool Connect()
        {
            return true;
        }
        byte[] GetData();
    }
}
