using System;
using DesignPatterns.DependencyInjection.Utilities;

namespace DesignPatterns.DependencyInjection
{
  public class BetterBusinessLogic : IBusinessLogic
  {
    private readonly IPerson _person;
    private readonly ILogger _logger;

    public BetterBusinessLogic(IPerson person, ILogger logger)
    {
      _person = person;
      _logger = logger;
    }
    
    public void ProcessPersonData()
    {
      Console.WriteLine("Do something with the customer data in Business Logic");
      _person.GetPersonData();
      _logger.Log("----------------------------------");
      _logger.Log("Hello FROM Better Business Logic");
      _person.PrintPerson();
      _logger.Log("Did everything");
      _logger.Log("----------------Better ---------------");
    }
  }
}