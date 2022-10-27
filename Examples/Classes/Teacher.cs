using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Teacher : Person
    {
        
        public string UserName { get; set; }
        public string Password { get; set; }

       public Teacher() : base("TC")
        {
            
        }
    }
}
