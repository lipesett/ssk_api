using Microsoft.EntityFrameworkCore;

namespace ApiSSK.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Calendario> Calendarios { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<CategoriaDivisao> CategoriasDivisoes { get; set; }
        public DbSet<Clima> Climas { get; set; }
        public DbSet<Divisao> Divisoes { get; set; }
        public DbSet<Inscricao> Inscricoes { get; set; }
        public DbSet<Kartodromo> Kartodromos { get; set; }
        public DbSet<MelhorVolta> MelhoresVoltas { get; set; }
        public DbSet<Piloto> Pilotos { get; set; }
        public DbSet<Pontuacao> Pontuacoes { get; set; }
        public DbSet<PontuacaoPilotoEtapa> PontuacoesEtapa { get; set; }
        public DbSet<Sentido> Sentidos { get; set; }
        public DbSet<Status> Status { get; set; }
        public DbSet<Temporada> Temporadas { get; set; }
        public DbSet<Tracado> Tracados { get; set; }
    }
}
