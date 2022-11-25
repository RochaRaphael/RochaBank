namespace RochaBank.Models
{
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Cellphone { get; set; }
        public double BankBalance { get; set; }
        public string? CNPJ { get; set; }
        public string? CPF { get; set; }
        public string CompanyOrPeople { get; set; }

        public ClientType Type { get; set; }

    }
}