using Task = TaskManager.Models.Task;

namespace TaskManager.States
{
    interface ITaskState
    {
        void Start(Task task);
        void Complete(Task task);
        void Cancel(Task task);
        string GetStateName();
    }
}
