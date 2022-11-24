using Microsoft.EntityFrameworkCore;
using RochaBank.Models;

namespace RochaBank.Data.Mapping
{
    public class CompanyMap : IEntityTypeConfiguration<Company>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Company> builder)
        {
            builder.ToTable("Company");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .ValueGeneratedOnAdd()
                .UseIdentityColumn();

            builder.Property(x => x.Name)
                .IsRequired()
                .HasColumnName("Name")
                .HasColumnType("NVARCHAR")
                .HasMaxLength(80);

            builder.Property(x => x.Cellphone)
                .IsRequired()
                .HasColumnName("Cellphone")
                .HasColumnType("NVARCHAR")
                .HasMaxLength(12);

            builder.Property(x => x.Cellphone)
                .IsRequired()
                .HasColumnName("CNPJ")
                .HasColumnType("NVARCHAR")
                .HasMaxLength(14);

            builder.Property(x => x.BankBalance)
                .IsRequired()
                .HasColumnName("Bank Balance")
                .HasColumnType("DECIMAL");

            builder.Property(x => x.TypeId)
                .IsRequired()
                .HasColumnName("CPF")
                .HasColumnType("NVARCHAR");


        }
    }
}