using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*namespace Working_with_collections
{
    public class Task
    {
        public int TaskId { get; set; }
        public string Description { get; set; }
        public Task (int taskId, string description)
        {
            TaskId = taskId;
            Description = description;
        }
        public override string ToString()
        {
            return $"Task ID: {TaskId}, Description: {Description}";
        }
    }
    public class TaskManager
    {
        private List<Task> tasks = new List <Task>();
        // Додавання нового завдання до списку
        public void AddTask (int Newid, string Newdesc)
        {
            Task Newtask = new Task(Newid, Newdesc);
            tasks.Add(Newtask);
            Console.WriteLine($"Task added: {Newtask}");
        }
        // Видалення завдання за ідентифікатором
        public void RemoveTask(int taskId)
        {
            Task taskToRemove = tasks.Find(x => x.TaskId == taskId);
            if (taskToRemove != null)
            {
                tasks.Remove(taskToRemove);
                Console.WriteLine($"Видалене завдання: {taskToRemove}");
            }
            else
            {
                Console.WriteLine($"Завдання з ідентифікатором {taskId} не знайдено.");
            }
        }
        // Виведення на екран усіх завдань у списку
        public void DisplayTasks()
        {
            Console.WriteLine("Список:");
            foreach (var task in tasks)
            {
                Console.WriteLine(task);
            }
        }
        // Тестування
            static void Main()
            {
                TaskManager taskManager = new TaskManager();
               
                // Додаємо кілька завдань до списку
                taskManager.AddTask(1, "Виконати домашнє завдання");

                taskManager.AddTask(2, "Поприбирати вдома");
                taskManager.AddTask(3, "Приготувати вечерю");

                taskManager.RemoveTask(1);
                // Виводимо всі завдання
                taskManager.DisplayTasks();

                Console.ReadLine();
            }
        }
    }
*/