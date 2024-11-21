using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ApiSSK.Data.Map
{
    public class PontuacaoPilotoEtapaMap : IEntityTypeConfiguration<PontuacaoPilotoEtapaModel>
    {
        public void Configure(EntityTypeBuilder<PontuacaoPilotoEtapaModel> builder)
        {
            builder.ToTable("PONTUACAO_PILOTO_ETAPA");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName("PPE_ID");
            builder.Property(x => x.TempoMelhorVolta).HasMaxLength(30).HasColumnName("PPE_TEMPO_VOLTA");
            builder.Property(x => x.MelhorVolta).IsRequired().HasColumnName("PPE_MELHOR_VOLTA");
            builder.Property(x => x.PilotoId).HasColumnName("PIL_ID");
            builder.Property(x => x.CalendarioId).HasColumnName("CAL_ID");
            builder.Property(x => x.PontuacaoId).HasColumnName("PON_ID");

            builder.HasOne(x => x.Piloto).WithOne().HasForeignKey<PontuacaoPilotoEtapaModel>(x => x.PilotoId);
            builder.HasOne(x => x.Calendario).WithOne().HasForeignKey<PontuacaoPilotoEtapaModel>(x => x.CalendarioId);
            builder.HasOne(x => x.Pontuacao).WithOne().HasForeignKey<PontuacaoPilotoEtapaModel>(x => x.PontuacaoId);
        }
    }
}