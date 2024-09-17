using ApiSSK.Data.Map;
using Microsoft.EntityFrameworkCore;

namespace ApiSSK.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<CalendarioModel> Calendarios { get; set; }
        public DbSet<CategoriaModel> Categorias { get; set; }
        public DbSet<CategoriaDivisaoModel> CategoriasDivisoes { get; set; }
        public DbSet<ClimaModel> Climas { get; set; }
        public DbSet<DivisaoModel> Divisoes { get; set; }
        public DbSet<InscricaoModel> Inscricoes { get; set; }
        public DbSet<KartodromoModel> Kartodromos { get; set; }
        public DbSet<MelhorVoltaModel> MelhoresVoltas { get; set; }
        public DbSet<MelhorVoltaDescModel> MelhoresVoltasDesc { get; set; }
        public DbSet<PilotoModel> Pilotos { get; set; }
        public DbSet<PontuacaoModel> Pontuacoes { get; set; }
        public DbSet<PontuacaoPilotoEtapaModel> PontuacoesEtapa { get; set; }
        public DbSet<SentidoModel> Sentidos { get; set; }
        public DbSet<StatusModel> Status { get; set; }
        public DbSet<TemporadaModel> Temporadas { get; set; }
        public DbSet<TracadoModel> Tracados { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CalendarioMap());
            modelBuilder.ApplyConfiguration(new CategoriaDivisaoMap());
            modelBuilder.ApplyConfiguration(new CategoriaMap());
            modelBuilder.ApplyConfiguration(new ClimaMap());
            modelBuilder.ApplyConfiguration(new DivisaoMap());
            modelBuilder.ApplyConfiguration(new InscricaoMap());
            modelBuilder.ApplyConfiguration(new KartodromoMap());
            modelBuilder.ApplyConfiguration(new MelhorVoltaMap());
            modelBuilder.ApplyConfiguration(new MelhorVoltaDescMap());
            modelBuilder.ApplyConfiguration(new PilotoMap());
            modelBuilder.ApplyConfiguration(new PontuacaoMap());
            modelBuilder.ApplyConfiguration(new PontuacaoPilotoEtapaMap());
            modelBuilder.ApplyConfiguration(new SentidoMap());
            modelBuilder.ApplyConfiguration(new StatusMap());
            modelBuilder.ApplyConfiguration(new TemporadaMap());
            modelBuilder.ApplyConfiguration(new TracadoMap());

            base.OnModelCreating(modelBuilder);
        }
    }
}
