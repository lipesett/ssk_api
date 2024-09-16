using ApiSSK.Data;
using ApiSSK.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ApiSSK.Repositories
{
    public class PilotoRepository : IPilotoRepository
    {
        private readonly DataContext _dbContext;
        public PilotoRepository(DataContext dataContext)
        {
            _dbContext = dataContext;
        }

        public async Task<List<PilotoModel>> GetAllPilotos()
        {
            return await _dbContext.Pilotos.ToListAsync();
        }
    }
}
