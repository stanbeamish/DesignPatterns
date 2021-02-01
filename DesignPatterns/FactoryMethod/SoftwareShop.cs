namespace DesignPatterns.FactoryMethod
{
    public class SoftwareShop
    {
        private readonly OfficeProgramFactory _officeProgramFactory = new OfficeProgramFactory();

        // GetProgram delegates the object creation for a program to the factory and then continues processing
        public OfficeProgram GetProgram(OfficeProg prog)
        {
            var program = _officeProgramFactory.CreateOfficeProgram(prog);

            program.PutToBasket();
            program.PutLabel();

            return program;
        }
    }
}