using EMR.Api.Models;
using EMR.Api.Services;
using Microsoft.AspNetCore.Mvc;

namespace EMR.Api.Controllers
{
    public class CalculationsController : Controller
    {
        private readonly ICalculateInvoices _calculateInvoices;
        public CalculationsController(ICalculateInvoices calculateInvoices)
        {
            _calculateInvoices = calculateInvoices;
        }
        [HttpGet("id")]
        public decimal CalculateInvoice(int id)
        {
            var invoice = new Invoice
            {

            };
            return _calculateInvoices.CalculateInvoice(invoice);
        }
    }
}
