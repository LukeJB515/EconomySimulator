using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EconomySimulator
{
    public class TaskQueueManager
    {
        private readonly Queue<GameTask> _taskQueue = new();
        private bool _isRunning = false;

        public void EnqueueTask(GameTask task)
        {
            _taskQueue.Enqueue(task);
            Console.WriteLine($"Queued task: {task.Name}");

            if (!_isRunning)
            {
                _ = ProcessQueueAsync();
            }
        }

        private async Task ProcessQueueAsync()
        {
            _isRunning = true;

            while (_taskQueue.Count > 0)
            {
                GameTask currentTask = _taskQueue.Dequeue();
                Console.WriteLine($"Executing task: {currentTask.Name}");

                TaskResult result = await currentTask.ExecuteAsync();
                Console.WriteLine(result.Message);
            }

            _isRunning = false;
            Console.WriteLine("Task queue is empty.");
        }
    }
}
