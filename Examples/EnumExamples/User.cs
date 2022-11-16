using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumExamples
{
    internal class User
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public UserStatus Status { get; set; } // Active = 0, Block = 1, Deleted = 2, Pending = 3
    }
}
