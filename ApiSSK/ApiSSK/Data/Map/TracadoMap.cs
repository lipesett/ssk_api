using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ApiSSK.Data.Map
{
    public class TracadoMap : IEntityTypeConfiguration<TracadoModel>
    {
        public void Configure(EntityTypeBuilder<TracadoModel> builder)
        {
            builder.ToTable("TRACADOS");
            builder.HasKey(x => x.TraId);
            builder.Property(x => x.TraId).HasColumnName("TRA_ID");
            builder.Property(x => x.TraNome).IsRequired().HasMaxLength(100).HasColumnName("TRA_NOME");
            builder.Property(x => x.TraDataEstreia).IsRequired().HasColumnName("TRA_DATA_ESTREIA");
            builder.Property(x => x.TraImg).HasMaxLength(255).HasColumnName("TRA_IMG");
            builder.Property(x => x.KartodromoId).IsRequired().HasColumnName("KAR_KARTODROMO");
            builder.Property(x => x.SentidoId).HasColumnName("SEN_SENTIDO");
            builder.Property(x => x.ClimaId).HasColumnName("CLI_CLIMA");
            builder.Property(x => x.MvEstreiaId).HasColumnName("MV_ESTREIA_ID");
            builder.Property(x => x.MvRecordId).HasColumnName("MV_RECORD_ID");

            builder.HasOne(x => x.Kartodromo).WithOne().HasForeignKey<TracadoModel>(x => x.KartodromoId);
            builder.HasOne(x => x.Sentido).WithOne().HasForeignKey<TracadoModel>(x => x.SentidoId);
            builder.HasOne(x => x.Clima).WithOne().HasForeignKey<TracadoModel>(x => x.ClimaId);
            builder.HasOne(x => x.MvEstreia).WithOne().HasForeignKey<TracadoModel>(x => x.MvEstreiaId);
            builder.HasOne(x => x.MvRecord).WithOne().HasForeignKey<TracadoModel>(x => x.MvRecordId);
        }
    }
}