namespace RochaBank.Models
{
    public class CompanyType : IClientType
    {
        public string Type { get; set; }
        public double BankFee { get; set; }
    }
}