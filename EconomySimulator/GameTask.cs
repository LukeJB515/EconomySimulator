using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EconomySimulator
{
    public class GameTask
    {
        public string Name { get; private set; }
        public TaskType Type { get; private set; }
        public int DurationSeconds { get; private set; }

        public GameTask(string name, TaskType type, int durationSeconds)
        {
            Name = name;
            Type = type;
            DurationSeconds = durationSeconds;
        }

        protected virtual TaskResult ResolveOutcome()
        {
            return new TaskResult(
                TaskOutcome.Success,
                "Task completed successfully."
            );
        }
    }
}
