using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfessionalEx5
{
    class WorkPlace
    {
        public void WorkForProgrammer(Worker worker)
        {
            Type type = worker.GetType();
            object[] attributes = type.GetCustomAttributes(typeof(AccessLevelAttribute),true);
            foreach (AccessLevelAttribute attribute in attributes)
            {
                if(attribute.Level.ToLower()== "programmer")
                {
                    Console.WriteLine($"Access is open to {worker.Name},{worker.Age} years old, {attribute.Level}");
                }
                else
                {
                    Console.WriteLine($"{worker.Name} {worker.Age} years old, {attribute.Level} can`t be access in programmer work");
                }
            }
        }

        public void WorkForManager(Worker worker)
        {
            Type type = worker.GetType();
            object[] attributes = type.GetCustomAttributes(typeof(AccessLevelAttribute), true);
            foreach (AccessLevelAttribute attribute in attributes)
            {
                if (attribute.Level.ToLower() == "manager")
                {
                    Console.WriteLine($"Access is open to {worker.Name},{worker.Age} years old, {attribute.Level}");
                }
                else
                {
                    Console.WriteLine($"{worker.Name} {worker.Age} years old, {attribute.Level} can`t be access in manager work");
                }
            }
        }

        public void WorkForDirector(Worker worker)
        {
            Type type = worker.GetType();
            object[] attributes = type.GetCustomAttributes(typeof(AccessLevelAttribute), true);
            foreach (AccessLevelAttribute attribute in attributes)
            {
                if (attribute.Level.ToLower() == "director")
                {
                    Console.WriteLine($"Access is open to {worker.Name},{worker.Age} years old, {attribute.Level}");
                }
                else
                {
                    Console.WriteLine($"{worker.Name} {worker.Age} years old, {attribute.Level} can`t be access in director work");
                }
            }
        }
    }
}
