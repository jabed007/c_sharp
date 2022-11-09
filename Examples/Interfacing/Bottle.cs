using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfacing
{
    public class Bottle : IContainer, IColorable, IClosable
    {
        public string Color { get; set; }
        public double Capacity { get; set; }
        private double contentAmount;
        private bool isOpen;

        public void AddContent(double amount)
        {
            contentAmount += amount;
        }

        public void Close()
        {
            isOpen = false;
        }

        public void Open()
        {
            isOpen=true;
        }

        public void RemoveContent(double amount)
        {
            contentAmount -= amount;
        }
    }
}
