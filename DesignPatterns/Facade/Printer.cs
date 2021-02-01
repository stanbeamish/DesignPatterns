using System;

namespace DesignPatterns.Facade
{
  public class Printer
  {
    public void TurnOn()
    {
      Console.WriteLine("Printer turned on.");
    }
    
    public void TurnOff()
    {
      Console.WriteLine("Computer turned off.");
    }

    public void ReceivePrintableDocument(PrintableDocument doc)
    {
      Console.WriteLine("Receiving PrintableDocument");
    }

    public bool IsPrintoutSuccessful(PrintableDocument doc)
    {
      Console.WriteLine("Trying to print document");
      return true;
    }
  }
}