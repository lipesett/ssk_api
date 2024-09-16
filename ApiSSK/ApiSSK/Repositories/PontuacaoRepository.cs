using ApiSSK.Data;
using ApiSSK.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ApiSSK.Repositories
{
    public class PontuacaoRepository : IPontuacaoRepository
    {
        private readonly DataContext _dbContext;
        public PontuacaoRepository(DataContext dataContext)
        {
            _dbContext = dataContext;
        }

        public async Task<List<PontuacaoModel>> GetAllPontuacoes()
        {
            return await _dbContext.Pontuacoes.ToListAsync();
        }
    }
}
