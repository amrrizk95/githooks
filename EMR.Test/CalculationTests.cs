using EMR.Api.Models;
using EMR.Api.Services;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMR.Test
{
    [TestClass]
    public class CalculationTests
    {
        private readonly ICalculateInvoices _calculateInvoices;

        [TestInitialize]
        public void Setup()
        {

        }
        public CalculationTests()
        {
            _calculateInvoices = new CalculateInvoices();
        }
        [TestMethod]
        public void Calculate()
        {
            // arrang
            var invoice = new Invoice
            {
                ExtraFees = 20,
                ProcessingFees = 40,
                VatPercentage = 0.18m
            };

            // act

            // result= (20+40) + (20+40)*0.18
            var result = _calculateInvoices.CalculateInvoice(invoice);
            var expected = 70.8m;

            // 
            // Assert
            Assert.AreNotEqual(expected, result);
        }
    }
}
