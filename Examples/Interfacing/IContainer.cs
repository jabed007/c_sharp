using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfacing
{
    public interface IContainer
    {
        double Capacity { get; set; }
        void AddContent(double amount);
        void RemoveContent(double amount);
    }
}
