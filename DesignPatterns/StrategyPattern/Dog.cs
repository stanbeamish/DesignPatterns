namespace DesignPatterns.StrategyPattern
{
    public abstract class Dog
    {
        private IBarkBehavior _barkBehavior = new BarkLoud();
        private IRunBehavior _runBehavior = new RunNormal();

        public void SetRunBehavior(IRunBehavior runBehavior)
        {
            this._runBehavior = runBehavior;
        }

        public void SetBarkBehavior(IBarkBehavior barkBehavior)
        {
            this._barkBehavior = barkBehavior;
        }

        public void Run()
        {
            _runBehavior.Run();
        }

        public void Bark()
        {
            _barkBehavior.Bark();
        }
    }
}
