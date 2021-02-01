using System;

namespace DesignPatterns.Facade
{
  public class PrintableDocument
  {
    public PrintableDocument()
    {
      
    }
  }
  
  
  public class Computer
  {
    public void TurnOn()
    {
      Console.WriteLine("Computer turned on.");
    }
    
    public void TurnOff()
    {
      Console.WriteLine("Computer turned off.");
    }

    public PrintableDocument CreateDocument()
    {
      Console.WriteLine("Create PrintableDocument");
      return new PrintableDocument();
    }

    public void SendDocumentToPrinter(PrintableDocument doc)
    {
      Console.WriteLine("Send PrintableDocument to Printer");
    }
  }
}