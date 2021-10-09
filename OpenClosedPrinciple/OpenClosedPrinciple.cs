using OpenClosedPrinciple.OCP;

namespace OpenClosedPrinciple
{
    public class OpenClosedPrinciple
    {
        public void OCP()
        {
            Invoice FInvoice = new FinalInvoice();
            Invoice PInvoice = new ProposedInvoice();
            Invoice RInvoice = new RecurringInvoice();

            double FInvoiceAmount = FInvoice.GetInvoiceDiscount(500);
            double PInvoiceAmount = PInvoice.GetInvoiceDiscount(500);
            double RInvoiceAmount = RInvoice.GetInvoiceDiscount(500);
        }  
    }
}
