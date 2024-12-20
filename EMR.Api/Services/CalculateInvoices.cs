using EMR.Api.Models;

namespace EMR.Api.Services
{
    public class CalculateInvoices : ICalculateInvoices
    {


        public decimal CalculateInvoice(Invoice invoice)
        {
            var vat = invoice.VatPercentage;
            var extraFees = invoice.ExtraFees;
            var processingFees = invoice.ProcessingFees;

            var subtotal = extraFees + processingFees;
            var totalFees = extraFees + processingFees + (subtotal) * vat;
            // adding some code 

            return totalFees;
           }
      }
}
