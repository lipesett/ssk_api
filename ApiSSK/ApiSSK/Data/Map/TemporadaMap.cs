using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ApiSSK.Data.Map
{
    public class TemporadaMap : IEntityTypeConfiguration<TemporadaModel>
    {
        public void Configure(EntityTypeBuilder<TemporadaModel> builder)
        {
            builder.ToTable("TEMPORADAS");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName("TEM_ID");
            builder.Property(x => x.NumTem).IsRequired().HasColumnName("TEM_NUMTEM");
            builder.Property(x => x.Nome).IsRequired().HasMaxLength(35).HasColumnName("TEM_NOME");
            builder.Property(x => x.Etapas).IsRequired().HasColumnName("TEM_ETAPAS");
            builder.Property(x => x.Inicio).IsRequired().HasColumnName("TEM_INICIO");
            builder.Property(x => x.Final).IsRequired().HasColumnName("TEM_FINAL");
            builder.Property(x => x.Ano).IsRequired().HasColumnName("TEM_ANO");
            builder.Property(x => x.StatusId).IsRequired().HasColumnName("STA_ID");

            builder.HasOne(x => x.Status).WithOne().HasForeignKey<TemporadaModel>(x => x.StatusId);
        }
    }
}