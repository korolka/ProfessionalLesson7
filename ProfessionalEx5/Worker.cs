using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfessionalEx5
{
    //[AccessLevel("test")]
    class Worker
    {
        string name;
        int age;

        public Worker(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public string Name
        {
            get { return name; }
        }

        public int Age { get { return age; } }
    }
}
