using Microsoft.EntityFrameworkCore;
using RochaBank.Data.Mapping;
using RochaBank.Models;

namespace RochaBank.DataContext
{
    public class BlogDataContext : DbContext
    {
        public DbSet<ClientType> ClientTypes { get; set; }
        public DbSet<Client> Clients { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
           => options.UseSqlServer("Server=localhost,1433;Database=RochaBank;User ID=sa;Password=1q2w3e4r@#$; Trusted_Connection=False; TrustServerCertificate=True;");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ClientTypeMap());
            modelBuilder.ApplyConfiguration(new ClientMap());
        }

    }
}