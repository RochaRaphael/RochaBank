using Microsoft.EntityFrameworkCore;
using RochaBank.Models;

namespace RochaBank.Data.Mapping
{
    public class CompanyMap : IEntityTypeConfiguration<Company>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Company> builder)
        {
            builder.ToTable("Company");
        }
    }
}