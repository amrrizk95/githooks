using EMR.Api.Models;

namespace EMR.Api.Services
{
    public interface ICalculateInvoices
    {

        public decimal CalculateInvoice(Invoice invoice);
    }
}
