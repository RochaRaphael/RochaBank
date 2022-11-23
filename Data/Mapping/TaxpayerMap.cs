using Microsoft.EntityFrameworkCore;
using RochaBank.Models;

namespace RochaBank.Data.Models
{
    public class TaxpayerMap : IEntityTypeConfiguration<Taxpayer>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Taxpayer> builder)
        {
            builder.ToTable("Taxpayer");

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
                .HasColumnName("CPF")
                .HasColumnType("NVARCHAR")
                .HasMaxLength(14);

            builder.Property(x => x.BankBalance)
                .IsRequired()
                .HasColumnName("Bank Balance")
                .HasColumnType("DECIMAL");

            builder.HasOne(x => x.Type)
            .WithMany()
            .HasForeignKey(x => x.TypeId);


        }
    }
}