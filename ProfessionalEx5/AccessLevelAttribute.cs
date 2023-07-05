using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfessionalEx5
{
    [AttributeUsage(AttributeTargets.All, AllowMultiple = false)]
    public class AccessLevelAttribute : Attribute
    {
        string level;
        public AccessLevelAttribute(string level)
        {
            this.level = level;
        }

        public string Level
        {
            get { return level; }
        }
    }
}
