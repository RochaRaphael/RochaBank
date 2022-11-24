namespace RochaBank.Interfaces
{
    public interface IClientType
    {
        public string Type { get; set; }
        public double BankFee { get; set; }
    }
}