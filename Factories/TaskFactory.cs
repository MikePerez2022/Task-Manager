using TaskManager.Models;
using Task = TaskManager.Models.Task;

namespace TaskManager.Factories
{
    class TaskFactory
    {
        public enum TaskType
        {
            Simple,
            Recurring
        }

        public static Task CreateTask(TaskType type, string name, string description)
        {
            switch(type)
            {
                case TaskType.Recurring:
                    return new SimpleTask(name, description);
                case TaskType.Simple:
                    return new RecurringTask(name, description);
                default:
                    return new Task(name, description);
            }
        }
    }
}
