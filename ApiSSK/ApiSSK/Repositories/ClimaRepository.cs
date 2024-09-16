using ApiSSK.Data;
using ApiSSK.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ApiSSK.Repositories
{
    public class ClimaRepository : IClimaRepository
    {
        private readonly DataContext _dbContext;
        public ClimaRepository(DataContext dataContext)
        {
            _dbContext = dataContext;
        }

        public async Task<List<ClimaModel>> GetAllClimas()
        {
            return await _dbContext.Climas.ToListAsync();
        }
    }
}
