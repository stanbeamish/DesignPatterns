using System;
using DesignPatterns.Facade;
using DesignPatterns.FactoryMethod;
using DesignPatterns.SingletonPattern;
using DesignPatterns.StrategyPattern;

namespace DesignPatterns
{
    static class Program
    {
        public static void Main(string[] args)
        {
            
            Console.WriteLine("----------- Strategy Pattern ------------");
            var husky = new Husky();
            husky.Bark();
            husky.Run();
        
            husky.SetBarkBehavior(new BarkElectronical());
            husky.Bark();
            
            
            Console.WriteLine("----------- Singleton ------------");
            var bankValues1 = BankValues.GetInstance();
            var bankValues2 = BankValues.GetInstance();
            Console.WriteLine(bankValues1 == bankValues2
                ? "Oh yes, I am the same instance"
                : "Nope, I am another BankValue instance.");

            Console.WriteLine("----------- Factory Method ------------");
            var shop = new SoftwareShop().GetProgram(OfficeProg.Powerpoint);
            
            Console.WriteLine("----------- Facade ------------");
            var officeTask = new OfficeFacade();
            officeTask.PrintDocument();
        }
    }
}