using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ApiSSK.Data.Map
{
    public class PilotoMap : IEntityTypeConfiguration<PilotoModel>
    {
        public void Configure(EntityTypeBuilder<PilotoModel> builder)
        {
            builder.ToTable("PILOTO");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName("PIL_ID");
            builder.Property(x => x.Nome).IsRequired().HasMaxLength(40).HasColumnName("PIL_NOME");
            builder.Property(x => x.Sobrenome).IsRequired().HasMaxLength(80).HasColumnName("PIL_SOBRENOME");
            builder.Property(x => x.Podiuns).IsRequired().HasColumnName("PIL_PODIUNS");
            builder.Property(x => x.CorridasOfc).IsRequired().HasColumnName("PIL_CORRIDAS_OFC");
            builder.Property(x => x.Campeao).IsRequired().HasColumnName("PIL_CAMPEAO");
            builder.Property(x => x.MelhorChegada).IsRequired().HasColumnName("PIL_MELHOR_CHEGADA");
            builder.Property(x => x.UltimaTemp).IsRequired().HasColumnName("PIL_ULTIMA_TEMP");
            builder.Property(x => x.VoltasRapidas).IsRequired().HasColumnName("PIL_VOLTAS_RAPIDAS");
            builder.Property(x => x.PolePosition).IsRequired().HasColumnName("PIL_POLE_POSITION");
            builder.Property(x => x.Peso).IsRequired().HasColumnName("PIL_PESO");
            builder.Property(x => x.MelhorQuali).IsRequired().HasColumnName("PIL_MELHOR_QUALI");
            builder.Property(x => x.LinksFotos).IsRequired().HasMaxLength(1500).HasColumnName("PIL_LINKS_FOTOS");
            builder.Property(x => x.StatusId).HasColumnName("STA_ID");

            builder.HasOne(x => x.Status).WithOne().HasForeignKey<PilotoModel>(x => x.StatusId);
        }
    }
}