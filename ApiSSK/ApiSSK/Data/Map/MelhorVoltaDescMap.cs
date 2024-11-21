using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ApiSSK.Data.Map
{
    public class MelhorVoltaDescMap : IEntityTypeConfiguration<MelhorVoltaDescModel>
    {
        public void Configure(EntityTypeBuilder<MelhorVoltaDescModel> builder)
        {
            builder.ToTable("MELHOR_VOLTA_DESC");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName("MVD_ID");
            builder.Property(x => x.Descricao).IsRequired().HasMaxLength(25).HasColumnName("MVD_DESCRICAO");
        }
    }
}