namespace EMR.Api.Models
{
    public class Invoice
    {
        public int Id { get; set; }
        public decimal VatPercentage { get; set; }
        public decimal ExtraFees { get; set; }
        public decimal ProcessingFees { get; set; }
        public decimal Subtotal { get { return (ExtraFees + ProcessingFees); } private set { } }
        public decimal  TotalFees { get { return Subtotal * ExtraFees; } private set { } }
    }
}
