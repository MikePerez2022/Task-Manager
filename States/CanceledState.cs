using Task = TaskManager.Models.Task;


namespace TaskManager.States
{
    class CanceledState : ITaskState
    {
        public void Start(Task task)
        {
            Console.WriteLine("Cannot start a canceled task.");
        }

        public void Complete(Task task)
        {
            Console.WriteLine("Cannot complete a canceled task.");
        }

        public void Cancel(Task task)
        {
            Console.WriteLine("Task is already canceled.");
        }

        public string GetStateName() { return "Canceled"; }
    }
}
