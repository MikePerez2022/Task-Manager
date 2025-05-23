using TaskManager.States;

namespace TaskManager.Models
{
    class Task
    {
        private ITaskState taskState;
        public string Title { get; set; }
        public string Description { get; set; }

        public Task(string title, string description = "")
        {
            Title = title;
            Description = description;
            taskState = new NewState();
        }

        public void SetState(ITaskState newState)
        {
            taskState = newState;
        }

        public void Start() { taskState.Start(this); }
        public void Complete() { taskState.Complete(this); }
        public void Cancel() { taskState.Cancel(this); }
        public string GetState() { return taskState.GetStateName(); }
    }
}
