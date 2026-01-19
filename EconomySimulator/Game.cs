using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EconomySimulator
{
    public class Game
    {
        public string Name { get; }
        public TaskType Type { get; }
        public int DurationSeconds { get; }

        private static readonly Random _random = new Random();

        public Game(string name, TaskType type, int durationSeconds)
        {
            Name = name;
            Type = type;
            DurationSeconds = durationSeconds;
        }

        public async System.Threading.Tasks.Task<TaskResult> ExecuteAsync()
        {
            Console.WriteLine($"");
            await System.Threading.Tasks.Task.Delay(DurationSeconds * 1000);

            return ResolveOutcome();
        }

        protected virtual TaskResult ResolveOutcome()
        {
            int roll = _random.Next(0, 100);

            if (roll < 70)
                return new TaskResult(TaskOutcome.Success, $"{Name} completed successfully.");
            else
                return new TaskResult(TaskOutcome.Failure, $"{Name} failed unexpectedly.");
        }
    }
}
