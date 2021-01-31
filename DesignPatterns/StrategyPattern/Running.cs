using System;

namespace DesignPatterns.StrategyPattern
{
    public class RunFast : IRunBehavior
    {
        public void Run()
        {
            Console.WriteLine("Running fast...");
        }
    }
    
    public class RunSlow : IRunBehavior
    {
        public void Run()
        {
            Console.WriteLine("Running slow...");
        }
    }
    
    public class RunNormal : IRunBehavior
    {
        public void Run()
        {
            Console.WriteLine("Running normal...");
        }
    }
    
    public class Limp : IRunBehavior
    {
        public void Run()
        {
            Console.WriteLine("Just limping...");
        }
    }
}