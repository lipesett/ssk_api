using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ApiSSK.Data.Map
{
    public class TemporadaMap : IEntityTypeConfiguration<TemporadaModel>
    {
        public void Configure(EntityTypeBuilder<TemporadaModel> builder)
        {
            builder.HasKey(x => x.TemId);
            builder.Property(x => x.TemNumTem).IsRequired();
            builder.Property(x => x.TemNome).IsRequired().HasMaxLength(35);
            builder.Property(x => x.TemEtapas).IsRequired();
            builder.Property(x => x.TemInicio).IsRequired();
            builder.Property(x => x.TemFinal).IsRequired();
            builder.Property(x => x.TemAno).IsRequired();
            builder.Property(x => x.StatusId).IsRequired();

            builder.HasOne(x => x.Status);
        }
    }
}