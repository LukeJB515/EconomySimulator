using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace EconomySimulator
{
    public class PlanJobFairTask : GameTask
    {
        public PlanJobFairTask()
            : base("Plan Job Fair", TaskType.Planning, 120)
        {
        }

        protected override TaskResult ResolveOutcome()
        {
            return base.ResolveOutcome();
        }
    }
}
