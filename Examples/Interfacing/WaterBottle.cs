using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfacing
{
    public class WaterBottle : Bottle
    {
        public new void Open()
        {
            base.Open();
            Console.WriteLine("Open from WaterBottle class");
        }

        public override double GetCurrentContentAmount()
        {
            return base.GetCurrentContentAmount();
        }
    }
}
