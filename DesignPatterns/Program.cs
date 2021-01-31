using System;
using DesignPatterns.SingletonPattern;
using DesignPatterns.StrategyPattern;

namespace DesignPatterns
{
    static class Program
    {
        public static void Main(string[] args)
        {
            // Strategy Pattern
            var husky = new Husky();
            husky.Bark();
            husky.Run();
        
            husky.SetBarkBehavior(new BarkElectronical());
            husky.Bark();
            
            // Singleton
            var bankValues = BankValues.GetInstance();
            bankValues.SetAccountFees(15);
        }
    }
}