using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfessionalEx5
{
    [AccessLevel("Manager")]
    class Manager: Worker
    {
        public Manager(string name, int age): base(name, age) { } 
    }
}
