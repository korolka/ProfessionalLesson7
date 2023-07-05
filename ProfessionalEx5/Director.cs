using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfessionalEx5
{
    [AccessLevel("Director")]
    class Director: Worker
    {
        public Director(string name, int age) : base(name, age) { }
    }
}
