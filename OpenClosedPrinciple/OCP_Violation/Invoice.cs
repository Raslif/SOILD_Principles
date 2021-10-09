namespace OpenClosedPrinciple.OCP_Violation
{
    public class Invoice
    {
        public double GetInvoiceDiscount(double amount, InvoiceType invoiceType)
        {
            double finalAmount;
            switch (invoiceType)
            {
                case InvoiceType.FinalInvoice:
                    finalAmount = amount - 100;
                    break;

                case InvoiceType.ProposedInvoice:
                    finalAmount = amount - 50;
                    break;

                default:
                    finalAmount = 10;
                    break;
            }

            return finalAmount;
        }

        public enum InvoiceType
        {
            FinalInvoice,
            ProposedInvoice
        };
    }
}
