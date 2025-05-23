using Task = TaskManager.Models.Task;

namespace TaskManager.States
{
    class InProgressState : ITaskState
    {
        public void Start(Task task)
        {
            Console.WriteLine("Task is already in progress.");
        }

        public void Complete(Task task)
        {
            task.SetState(new CompletedState());
            Console.WriteLine("Task completed.");
        }

        public void Cancel(Task task)
        {
            task.SetState(new CanceledState());
            Console.WriteLine("Task canceled.");
        }

        public string GetStateName() { return "In Progress"; }
}
}
