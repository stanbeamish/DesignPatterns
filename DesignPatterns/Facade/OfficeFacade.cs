using System;

namespace DesignPatterns.Facade
{
  public class OfficeFacade
  {
    Computer _computer = new Computer();
    Printer _printer = new Printer();
    
    public void PrintDocument()
    {
      _computer.TurnOn();
      var document = _computer.CreateDocument();
      _computer.SendDocumentToPrinter(document);
      _printer.TurnOn();
      _printer.ReceivePrintableDocument(document);
      var printOk = _printer.IsPrintoutSuccessful(document);
      Console.WriteLine($"Printing Process: {printOk}");
      _printer.TurnOff();
      _computer.TurnOff();
    }
  }
}