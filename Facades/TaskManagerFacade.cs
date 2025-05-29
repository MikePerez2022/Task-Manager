using TaskManager.Factories;
using Task = TaskManager.Models.Task;
using TaskFactory = TaskManager.Factories.TaskFactory;

namespace TaskManager.Facade
{
    public class TaskManagerFacade
    {
        private readonly Dictionary<int, Task> tasks = new();
        private int nextId = 1;

        public int CreateTask(TaskType type, string title, string description = "")
        {
            var task = TaskFactory.CreateTask(type, title, description);
            var id = nextId++;
            tasks[id] = task;
            Console.WriteLine($"Created {type} Task #{id}: {title}");
            return id;
        }

        public void StartTask(int id)
        {
            if (tasks.TryGetValue(id, out var task))
            {
                task.Start();
                Console.WriteLine($"Task #{id} started.");
            }
        }

        public void CompleteTask(int id)
        {
            if (tasks.TryGetValue(id, out var task))
            {
                task.Complete();
                Console.WriteLine($"Task #{id} completed.");
            }
        }

        public void CancelTask(int id)
        {
            if (tasks.TryGetValue(id, out var task))
            {
                task.Cancel();
                Console.WriteLine($"Task #{id} cancelled.");
            }
        }

        public void PrintTasks()
        {
            foreach (var task in tasks)
            {
                Console.WriteLine($"Task #{task.Key}: '{task.Value.Title}' - {task.Value.GetState()}");
            }
        }
    }
}
