using System;
using System.ComponentModel.Design;

namespace DesignPatterns.FactoryMethod
{
    public enum OfficeProg
    {
        Word,
        Powerpoint,
        Excel,
        None
    }

    public class Word : OfficeProgram
    {
        public Word()
        {
            Console.WriteLine("I am Word");
        }
    }

    public class Excel : OfficeProgram
    {
        public Excel()
        {
            Console.WriteLine("I am Excel");
        }
    }

    public class Powerpoint : OfficeProgram
    {
        public Powerpoint()
        {
            Console.WriteLine("I am Powerpoint");
        }
    }

    public abstract class OfficeProgram
    {
        public void PutToBasket()
        {
            Console.WriteLine("Put in Basket");
        }

        public void PutLabel()
        {
            Console.WriteLine("Put label");   
        }
    }
    
    public class OfficeProgramFactory
    {
        public OfficeProgram CreateOfficeProgram(OfficeProg prog)
        {
            switch (prog)
            {
                case OfficeProg.Word:
                    return new Word();
                case OfficeProg.Powerpoint:
                    return new Powerpoint();
                case OfficeProg.Excel:
                    return new Excel();
                case OfficeProg.None:
                    return null;
                default:
                    throw new ArgumentOutOfRangeException(nameof(prog), prog, null);
            } 
        }
    }
}