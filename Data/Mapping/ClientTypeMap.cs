using Microsoft.EntityFrameworkCore;
using RochaBank.Models;

namespace RochaBank.Data.Mapping
{
    public class ClientTypeMap : IEntityTypeConfiguration<ClientType>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<ClientType> builder)
        {
            builder.ToTable("ClientType");
        }
    }
}