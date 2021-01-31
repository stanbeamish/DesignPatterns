namespace DesignPatterns.StrategyPattern
{
    public class Husky : Dog
    {
        public Husky()
        {
            SetBarkBehavior(new BarkSilent());
            SetRunBehavior(new RunFast());
        }
    }
}