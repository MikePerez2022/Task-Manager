using TaskManager.Facade;
using TaskManager.Factories;

namespace TaskManager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var manager = new TaskManagerFacade();

            int task1 = manager.CreateTask(TaskType.Simple, "Paint House", "Clear living room wall, set up plastic below, and paint wall.");
            int task2 = manager.CreateTask(TaskType.Recurring, "Daily Standup", "Attend every day at 10:30am.");

            manager.StartTask(task1);
            manager.CompleteTask(task1);

            manager.StartTask(task2);
            manager.CancelTask(task2);

            Console.WriteLine("\n--- Task Summary ---\n");
            manager.PrintTasks();
        }
    }
}
