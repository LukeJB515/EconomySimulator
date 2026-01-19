using System;
using System.Linq;

namespace EconomySimulator
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Welcome to the game.");
            Console.WriteLine("It is luck based.");
            Console.WriteLine("So if you win, don't brag about your skill.");
            Console.WriteLine("Nobody has real skills in Economy Simulator.");
            TaskQueueManager queue = new();

            queue.EnqueueTask(new PlanJobFairTask());
            queue.EnqueueTask(new PlanJobFairTask());

            Console.ReadLine();
        }
    }
}