using Microsoft.EntityFrameworkCore;
using RochaBank.Models;

namespace RochaBank.Data.Models
{
    public class TaxpayerMap : IEntityTypeConfiguration<Taxpayer>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Taxpayer> builder)
        {
            builder.ToTable("Taxpayer");
        }
    }
}