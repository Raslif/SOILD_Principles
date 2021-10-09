namespace OpenClosedPrinciple.OCP
{
    public class ProposedInvoice : Invoice
    {
        public override double GetInvoiceDiscount(double amount)
        {
            return base.GetInvoiceDiscount(amount) - 40;
        }
    }
}
