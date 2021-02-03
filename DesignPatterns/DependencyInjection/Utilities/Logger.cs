using System;

namespace DesignPatterns.DependencyInjection.Utilities
{
  public class Logger : ILogger
  {
    public void Log(string message)
    {
      Console.WriteLine($"Logging {message}");
    }
  }
}