using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceUse
{
    internal class KeyBoard : IUSBDevice
    {
        public byte[] GetData()
        {
            return UnicodeEncoding.UTF8.GetBytes("Data From KeyBoard");
        }
    }
}
