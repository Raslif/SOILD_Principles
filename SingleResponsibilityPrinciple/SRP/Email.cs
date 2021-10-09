using System;

namespace SingleResponsibilityPrinciple.SRP
{
    public class Email
    {
        private readonly Log _log = null;
        public Email()
        {
            _log = new Log();
        }
        public string SendConfirmationEmailAfterRegistration()
        {
            try
            {
                return "Send confirmation email to customer after registration";
            }
            catch(Exception exception)
            {
                _log.Error(exception);
                throw new Exception("Email Sending Failed");
            }
        }
    }
}
