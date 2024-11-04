using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Working_with_collections
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public User(int id, string name)
        {
            Id = id;
            Name = name;
        }
        public override string ToString()
        {
            return $"Айді студента: {Id}, Ім'я: {Name}";
        }
    }
    public class UserManager
    {
        private List<User> students = new List<User>();
        // Додавання нового користувача до списку
        public void AddTask(int Newid, string Newname)
        {
            User Newstudent = new User(Newid, Newname);
            students.Add(Newstudent);
            Console.WriteLine($"Доданий студент: {Newstudent}");
        }
        // Видалення студента за ідентифікатором
        public void RemoveTask(int studId)
        {
            User taskToRemove = students.Find(x => x.Id == studId);
            if (taskToRemove != null)
            {
                students.Remove(taskToRemove);
                Console.WriteLine($"Видалений студент: {taskToRemove}");
            }
            else
            {
                Console.WriteLine($"Студент з ідентифікатором {studId} не знайдено.");
            }
        }
        // Виведення на екран усіх студентів у списку
        public void DisplayTasks()
        {
            Console.WriteLine("Список студентів:");
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
        }
        // Тестування
        static void Main()
        {
            UserManager taskManager = new UserManager();

            // Додаємо кілька студентів до списку
            taskManager.AddTask(1, "Alex");

            taskManager.AddTask(2, "Victoria");
            taskManager.AddTask(3, "Kate");

            taskManager.RemoveTask(1);
            // Виводимо всіх студентів
            taskManager.DisplayTasks();

            Console.ReadLine();
        }
    }
}
