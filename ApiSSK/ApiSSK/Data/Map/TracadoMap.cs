using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ApiSSK.Data.Map
{
    public class TracadoMap : IEntityTypeConfiguration<TracadoModel>
    {
        public void Configure(EntityTypeBuilder<TracadoModel> builder)
        {
            builder.HasKey(x => x.TraId);
            builder.Property(x => x.TraNome).IsRequired().HasMaxLength(45);
            builder.Property(x => x.TraDataEstreia).IsRequired();
            builder.Property(x => x.TraImg).HasMaxLength(1000);
            builder.Property(x => x.KartodromoId).IsRequired();
            builder.Property(x => x.SentidoId);
            builder.Property(x => x.ClimaId);
            builder.Property(x => x.MvEstreiaId);
            builder.Property(x => x.MvRecordId);

            builder.HasOne(x => x.Kartodromo);
            builder.HasOne(x => x.Sentido);
            builder.HasOne(x => x.Clima);
            builder.HasOne(x => x.MvEstreia);
            builder.HasOne(x => x.MvRecord);
        }
    }
}