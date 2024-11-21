using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ApiSSK.Data.Map
{
    public class ClimaMap : IEntityTypeConfiguration<ClimaModel>
    {
        public void Configure(EntityTypeBuilder<ClimaModel> builder)
        {
            builder.ToTable("CLIMA");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName("CLI_ID");
            builder.Property(x => x.Descricao).IsRequired().HasMaxLength(50).HasColumnName("CLI_DESC");
        }
    }
}