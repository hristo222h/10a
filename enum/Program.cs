using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @enum
{

    public enum TaskPriority
    {
        Low = 1,
        Medium = 2,
        High = 3
    }

    public class Task
    {
        public string Name { get; set; }
        public TaskPriority Priority { get; set; }

        public Task(string name, TaskPriority priority)
        {
            Name = name;
            Priority = priority;
        }
    }

    public class Program
    {
        public static void Main()
        {
            List<Task> tasks = new List<Task>();

            // 3te taska:
            tasks.Add(new Task("Gledane na televisiq", TaskPriority.Low));
            tasks.Add(new Task("Hodene do magazina", TaskPriority.Medium));
            tasks.Add(new Task("Uchene po biologiq", TaskPriority.High));

            // Otpechatvane
            foreach (var task in tasks)
            {
                Console.WriteLine($"{task.Name} - {task.Priority}");
            }
        }
    }


}
