using Microsoft.EntityFrameworkCore;
using RochaBank.Models;

namespace RochaBank.Data.Mapping
{
    public class ClientMap : IEntityTypeConfiguration<Client>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Client> builder)
        {
            builder.ToTable("Client");

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

            builder.Property(x => x.BankBalance)
                .IsRequired()
                .HasColumnName("Bank Balance")
                .HasColumnType("DECIMAL");

            builder.Property(x => x.CNPJ)
                .HasColumnName("CNPJ")
                .HasColumnType("NVARCHAR")
                .HasMaxLength(14);

            builder.Property(x => x.CPF)
                .HasColumnName("CPF")
                .HasColumnType("NVARCHAR")
                .HasMaxLength(11);

            builder.Property(x => x.CompanyOrPeople)
                .IsRequired()
                .HasColumnName("CompanyOrPeople")
                .HasColumnType("NVARCHAR")
                .HasMaxLength(7);

            builder
                .HasOne(x => x.Type)
                .WithMany(x => x.Clients)
                .HasConstraintName("FK_ClientType_Client");
        }
    }
}