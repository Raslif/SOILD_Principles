using System;

namespace SingleResponsibilityPrinciple.SRP
{
    public class Customer
    {
        private readonly Email _email = null;
        private readonly Log _log = null;
        public Customer()
        {
            _email = new Email();
            _log = new Log();
        }
        public void Register()
        {
            try
            {
                // Customer registration logic & DB save
                _email.SendConfirmationEmailAfterRegistration();
            }
            catch(Exception exception)
            {
                _log.Error(exception);
            }
        }
    }
}
