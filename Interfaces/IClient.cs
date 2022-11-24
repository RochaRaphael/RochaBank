namespace RochaBank.Interfaces
{
    public interface IClient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Cellphone { get; set; }
        public double BankBalance { get; set; }

        public IClientType Type { get; set; }

    }
}