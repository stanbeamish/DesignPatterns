using System;

namespace DesignPatterns.StrategyPattern
{
    public class BarkLoud : IBarkBehavior
    {
        public void Bark()
        {
            Console.WriteLine("Barking LOUD!");
        }
    }

    public class BarkSilent : IBarkBehavior
    {
        public void Bark()
        {
            Console.WriteLine("Barking silent.");
        }
    }

    public class BarkElectronical : IBarkBehavior
    {
        public void Bark()
        {
            Console.WriteLine("B A R K I N G");
        }
    }
}