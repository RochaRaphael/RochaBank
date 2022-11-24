namespace RochaBank.Models
{
    public class Taxpayer : IClient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Cellphone { get; set; }
        public double BankBalance { get; set; }
        public string CPF { get; set; }

        public ClientType TypeId { get; set; }
    }
}