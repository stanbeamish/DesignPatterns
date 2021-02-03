using System;

namespace DesignPatterns.DependencyInjection.Utilities
{
  public class Person : IPerson
  {
    public void GetPersonData()
    {
      Console.WriteLine("Getting the data of a customer");
    }

    public void PrintPerson()
    {
      Console.WriteLine("Printing the data of a customer");
    }
  }
}