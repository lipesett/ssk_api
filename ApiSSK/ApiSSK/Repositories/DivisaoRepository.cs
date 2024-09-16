using ApiSSK.Data;
using ApiSSK.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ApiSSK.Repositories
{
    public class DivisaoRepository : IDivisaoRepository
    {
        private readonly DataContext _dbContext;
        public DivisaoRepository(DataContext dataContext)
        {
            _dbContext = dataContext;
        }

        public async Task<List<DivisaoModel>> GetAllDivisoes()
        {
            return await _dbContext.Divisoes.ToListAsync();
        }
    }
}