using Task = TaskManager.Models.Task;

namespace TaskManager.States
{
    class InProgressState : ITaskState
    {
        public void Cancel(Task task)
        {
            throw new NotImplementedException();
        }

        public void Complete(Task task)
        {
            throw new NotImplementedException();
        }

        public string GetStateName()
        {
            throw new NotImplementedException();
        }

        public void Start(Task task)
        {
            throw new NotImplementedException();
        }
    }
}
