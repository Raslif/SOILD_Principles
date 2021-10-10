namespace LiskovSubstitutionPrinciple
{
    public class LSP_Violation
    {
        public void LSPViolation()
        {
            Desktop desktop = new Laptop();
            var listOfLaptopConfigurations = desktop.GetConfigurations();
        }
    }

    public class Desktop
    {
        public virtual string GetConfigurations()
        {
            return "List of Dektop Configurations";
        }
    }
    public class Laptop : Desktop
    {
        public override string GetConfigurations()
        {
            return "List of Laptop Configurations";
        }
    }
}
