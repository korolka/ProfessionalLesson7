using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfessionalEx5
{
    [AccessLevel("Programmer")]
    class Programmer:Worker
    {
        public Programmer(string name, int age): base(name, age) { }
    }
}
