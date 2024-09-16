using ApiSSK.Data;
using ApiSSK.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ApiSSK.Repositories
{
    public class PontuacaoPilotoEtapaRepository : IPontuacaoPilotoEtapaRepository
    {
        private readonly DataContext _dbContext;
        public PontuacaoPilotoEtapaRepository(DataContext dataContext)
        {
            _dbContext = dataContext;
        }

        public async Task<List<PontuacaoPilotoEtapaModel>> GetAllPontuacaoPilotoEtapas()
        {
            return await _dbContext.PontuacoesEtapa.ToListAsync();
        }
    }
}
