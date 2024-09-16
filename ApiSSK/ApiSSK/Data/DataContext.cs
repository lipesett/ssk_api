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
        public DbSet<PilotoModel> Pilotos { get; set; }
        public DbSet<Pontuacao> Pontuacoes { get; set; }
        public DbSet<PontuacaoPilotoEtapa> PontuacoesEtapa { get; set; }
        public DbSet<Sentido> Sentidos { get; set; }
        public DbSet<Status> Status { get; set; }
        public DbSet<Temporada> Temporadas { get; set; }
        public DbSet<Tracado> Tracados { get; set; }
    }
}
