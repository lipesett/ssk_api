using ApiSSK.Data;
using ApiSSK.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ApiSSK.Repositories
{
    public class InscricaoRepository : IInscricaoRepository
    {
        private readonly DataContext _dbContext;
        public InscricaoRepository(DataContext dataContext)
        {
            _dbContext = dataContext;
        }

        public async Task<List<InscricaoModel>> GetAllInscricoes()
        {
            return await _dbContext.Inscricoes.ToListAsync();
        }
    }
}
