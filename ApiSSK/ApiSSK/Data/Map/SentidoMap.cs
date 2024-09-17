using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ApiSSK.Data.Map
{
    public class SentidoMap : IEntityTypeConfiguration<SentidoModel>
    {
        public void Configure(EntityTypeBuilder<SentidoModel> builder)
        {
            builder.HasKey(x => x.SenId);
            builder.Property(x => x.SenDesc).IsRequired().HasMaxLength(30);
        }
    }
}