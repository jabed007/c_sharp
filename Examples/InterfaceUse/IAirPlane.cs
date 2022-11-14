using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceUse
{
    public interface IAirPlane
    {
        void StartEngine();
        public void StopEngine()
        {
            Console.WriteLine("From Air Plane");
        }
    }
}
