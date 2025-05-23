using Task = TaskManager.Models.Task;

namespace TaskManager.States
{
    class NewState : ITaskState
    {
        public void Start(Task task)
        {
            task.SetState(new InProgressState());
            Console.WriteLine("Task started.");
        }

        public void Complete(Task task)
        {
            Console.WriteLine("Cannot complete a task that hasn't started.");
        }

        public void Cancel(Task task)
        {
            task.SetState(new CanceledState());
            Console.WriteLine("Task canceled.");
        }

        public string GetStateName() { return "New"; }
    }
}
