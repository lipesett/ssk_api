using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ApiSSK.Data.Map
{
    public class ClimaMap : IEntityTypeConfiguration<ClimaModel>
    {
        public void Configure(EntityTypeBuilder<ClimaModel> builder)
        {
            builder.ToTable("CLIMA");
            builder.HasKey(x => x.CliId);
            builder.Property(x => x.CliId).HasColumnName("CLI_ID");
            builder.Property(x => x.CliDesc).HasColumnName("CLI_DESC").IsRequired().HasMaxLength(50);
        }
    }
}