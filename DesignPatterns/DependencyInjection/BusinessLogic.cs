using System;
using DesignPatterns.DependencyInjection.Utilities;

namespace DesignPatterns.DependencyInjection
{
  public class BusinessLogic : IBusinessLogic
  {
    private readonly IPerson _person;
    private readonly ILogger _logger;

    public BusinessLogic(IPerson person, ILogger logger)
    {
      _person = person;
      _logger = logger;
    }
    
    public void ProcessPersonData()
    {
      Console.WriteLine("Do something with the customer data in Business Logic");
      _person.GetPersonData();
      _logger.Log("Hello Logger");
      _person.PrintPerson();
      _logger.Log("Did everything");
    }
  }
}