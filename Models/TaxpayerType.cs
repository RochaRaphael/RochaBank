namespace RochaBank.Models
{
    public class TaxpayerType : IClientType
    {
        public string Type { get; set; }
        public double BankFee { get; set; }
    }
}