using Microsoft.EntityFrameworkCore;
using RochaBank.Models;

namespace RochaBank.Data.Mapping
{
    public class ClientTypeMap : IEntityTypeConfiguration<ClientType>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<ClientType> builder)
        {
            builder.ToTable("CompanyType");

            //Primary key
            builder.HasKey(x => x.Type);

            builder.Property(x => x.Type)
                .IsRequired()
                .HasColumnName("Type")
                .HasColumnType("NVARCHAR")
                .HasMaxLength(80);

            builder.Property(x => x.BankFee)
                .IsRequired()
                .HasColumnName("BankFee")
                .HasColumnType("DECIMAL");
        }
    }
}