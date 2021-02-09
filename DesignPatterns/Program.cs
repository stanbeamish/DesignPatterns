using System;
using System.Collections.Generic;
using Autofac;
using DesignPatterns.Facade;
using DesignPatterns.FactoryMethod;
using DesignPatterns.Repository;
using DesignPatterns.Repository.Entities;
using DesignPatterns.SingletonPattern;
using DesignPatterns.State;
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
            
            Console.WriteLine("----------- State ------------");
            var lumpi = new Doggy();
            lumpi.Play();
            lumpi.Anger();
            lumpi.GiveMeal();
            lumpi.Stroke();
            lumpi.LeaveAlone();

            Console.WriteLine("----------- DI with Autofac ------------");
            var container = ContainerConfig.Configure();
            
            using (var scope = container.BeginLifetimeScope())
            {
                var app = scope.Resolve<IApplication>();
                app.Run();
            }
            
            Console.WriteLine("----------- Repository ------------");
            ArticleRepository artRepo = new ArticleRepository();
            List<Article> artList = artRepo.ReadAll();
            Console.WriteLine($"Found {artList.Count} articles in the List");
            artRepo.Create(new Article{});
            var artLatest = artRepo.ReadLatest();
            Console.WriteLine($"Title: {artLatest.Title}, ID: {artLatest.Id}");
            artList = artRepo.ReadAll();
            Console.WriteLine($"Found {artList.Count} articles in the List");
            artRepo.Update(new Article{});
            Console.WriteLine($"FOUND: {artRepo.ReadById(1).Title}");
            artRepo.Delete(new Article{});
            artList = artRepo.ReadAll();
            Console.WriteLine($"Found {artList.Count} articles in the List");
        }
    }
}