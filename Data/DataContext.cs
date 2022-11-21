using Microsoft.EntityFrameworkCore;
using RochaBank.Models;

namespace RochaBank.DataContext
{
    public class BlogDataContext : DbContext
    {
        public DbSet<ClientType> ClientTypes { get; set; }
        public DbSet<Company> Companys { get; set; }
        public DbSet<Taxpayer> Taxpayers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
           => options.UseSqlServer("Server=localhost,1433;Database=RochaBank;User ID=sa;Password=1q2w3e4r@#$");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }

    }
}