using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceUse
{
    public class HoverCraft : ICar, IAirPlane
    {
        public void StartEngine()
        {
            //throw new NotImplementedException();
            Console.WriteLine("Engine Start");
        }
    }
}
