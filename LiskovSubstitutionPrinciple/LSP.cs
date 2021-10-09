namespace LiskovSubstitutionPrinciple
{
    public class LSP
    {
        public void LSPrinciple()
        {
            IDeveloper developer = new JuniorDeveloper();
            string jrDeveloperSkills = developer.GetSkills();

            developer = new SeniorDeveloper();
            string srDeveloperSkills = developer.GetSkills();
        }       
    }

    public interface IDeveloper
    {
        string GetSkills();
    }
    public class JuniorDeveloper : IDeveloper
    {
        public string GetSkills()
        {
            return ".NET Mvc, .NET Web API, Javascript, MSSQL.";
        }
    }
    public class SeniorDeveloper : IDeveloper
    {
        public string GetSkills()
        {
            return ".NET Mvc, .NET Web API, .NetCore MVC, .NetCore MVC, Javascript, Angualar, MSSQL, etc...";
        }
    }
}
