namespace RochaBank.Models
{
    public class ClientType
    {
        public string Type { get; set; }
        public double BankFee { get; set; }
        public IList<Client> Clients { get; set; }
    }
}