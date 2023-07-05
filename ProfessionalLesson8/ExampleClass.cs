using System.Reflection;

namespace ProfessionalLesson8
{
    class ExampleClass
    {
        [Obsolete("This is old method, call ExampleMethod2",false)]
        public void ExampleMethod1()
        {
            Console.WriteLine("Old method");
        }

        public void ExampleMethod2()
        {
            Console.WriteLine("New method");
        }

        [Obsolete("This is old method, call ExampleMethod2",true)]
        public void ExampleMethod3()
        {
            Console.WriteLine("Old method2");
        }
    }
}
