//Завдання 2

//Створіть клас і застосуйте до його методів атрибут Obsolete спочатку у формі,
//що просто виводить попередження, а потім у формі, що перешкоджає компіляції.
//Продемонструйте роботу атрибута з прикладу виклику даних методів.
namespace ProfessionalLesson8
{
    internal class Program
    {
        static void Main()
        {
            ExampleClass exampleClass = new();
            exampleClass.ExampleMethod1();
            exampleClass.ExampleMethod2();
            exampleClass.ExampleMethod3();
        }
    }
}