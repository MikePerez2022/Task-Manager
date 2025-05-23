using Task = TaskManager.Models.Task;

namespace TaskManager.States
{
    class CompletedState : ITaskState
    {
        public void Start(Task task)
        {
            Console.WriteLine("Cannot start a completed task.");
        }

        public void Complete(Task task)
        {
            Console.WriteLine("Task is already completed.");
        }

        public void Cancel(Task task)
        {
            Console.WriteLine("Cannot cancel a completed task.");
        }

        public string GetStateName() => "Completed";
    }
}
