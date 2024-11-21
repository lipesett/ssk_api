using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ApiSSK.Data.Map
{
    public class InscricaoMap : IEntityTypeConfiguration<InscricaoModel>
    {
        public void Configure(EntityTypeBuilder<InscricaoModel> builder)
        {
            builder.ToTable("INSCRICOES");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName("INS_ID");
            builder.Property(x => x.DataInscricao).IsRequired().HasColumnName("INS_DATA_INSCRICAO");
            builder.Property(x => x.Pago).HasColumnName("INS_PAGO");
            builder.Property(x => x.TemporadaId).HasColumnName("TEM_ID");
            builder.Property(x => x.PilotoId).HasColumnName("PIL_ID");
            builder.Property(x => x.CategoriaId).HasColumnName("CAT_ID");
            builder.Property(x => x.DivisaoId).HasColumnName("DIV_ID") ;

            builder.HasOne(x => x.Temporada).WithOne().HasForeignKey<InscricaoModel>(x => x.TemporadaId);
            builder.HasOne(x => x.Piloto).WithOne().HasForeignKey<InscricaoModel>(x => x.PilotoId);
            builder.HasOne(x => x.Categoria).WithOne().HasForeignKey<InscricaoModel>(x => x.CategoriaId);
            builder.HasOne(x => x.Divisao).WithOne().HasForeignKey<InscricaoModel>(x => x.DivisaoId);
        }
    }
}