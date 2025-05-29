using TaskManager.Models;
using Task = TaskManager.Models.Task;

namespace TaskManager.Factories
{
    public enum TaskType
    {
        Simple,
        Recurring
    }

    static class TaskFactory
    {
        public static Task CreateTask(TaskType type, string name, string description)
        {
            switch(type)
            {
                case TaskType.Recurring:
                    return new RecurringTask(name, description);
                case TaskType.Simple:
                    return new SimpleTask(name, description);
                default:
                    return new Task(name, description);
            }
        }
    }
}
