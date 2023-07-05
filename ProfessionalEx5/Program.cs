//Завдання 5

//Створіть атрибут користувача AccessLevelAttribute, який дозволяє визначити рівень доступу користувача до системи.
//Сформуйте склад співробітників певної фірми як набору класів, наприклад, Manager, Programmer, Director.
//За допомогою атрибута AccessLevelAttribute розподіліть рівні доступу персоналу
//та відобразіть на екрані реакцію системи на спробу кожного співробітника отримати доступ до захищеної секції.
namespace ProfessionalEx5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WorkPlace workPlace= new WorkPlace();
            Programmer programmer = new Programmer("Vlad", 22);
            Manager manager = new Manager("Alise", 21);
            Director director = new Director("Andrey", 30);
            workPlace.WorkForProgrammer(programmer);
            workPlace.WorkForProgrammer(manager);
            workPlace.WorkForManager(manager);
            workPlace.WorkForDirector(director);
            workPlace.WorkForManager(director);
        }
    }
}