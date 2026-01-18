using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EconomySimulator
{
    public class TaskResult
    {
        public TaskOutcome Outcome { get; }
        public string Message { get; }

        public TaskResult(TaskOutcome outcome, string message)
        {
            Outcome = outcome;
            Message = message;
        }
    }
}
