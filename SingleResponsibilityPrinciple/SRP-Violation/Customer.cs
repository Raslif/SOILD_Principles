namespace SingleResponsibilityPrinciple.SRP_Violation
{
    public class Customer
    {
        public void Register()
        {          
            try
            {
                // Customer registration logic & DB save
                SendConfirmationEmailAfterRegistration();
            }
            catch
            {
                Log();
            }
        }

        public string SendConfirmationEmailAfterRegistration()
        {
            try
            {
                return "Send confirmation email to customer after registration";
            }
            catch
            {
                Log();
            }

            return "Registration Failed.";
        }

        public void Log()
        {
            // Logic to log the details to DB or File...
        }
    }
}
