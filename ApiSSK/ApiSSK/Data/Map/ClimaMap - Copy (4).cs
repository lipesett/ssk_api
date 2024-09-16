using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ApiSSK.Data.Map
{
    public class ClimaMap : IEntityTypeConfiguration<ClimaModel>
    {
        public void Configure(EntityTypeBuilder<ClimaModel> builder)
        {
            builder.HasKey(x => x.CliId);
            builder.Property(x => x.CliDesc).IsRequired().HasMaxLength(20);
        }
    }
}