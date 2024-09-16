using ApiSSK.Data;
using ApiSSK.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ApiSSK.Repositories
{
    public class TemporadaRepository : ITemporadaRepository
    {
        private readonly DataContext _dbContext;
        public TemporadaRepository(DataContext dataContext)
        {
            _dbContext = dataContext;
        }

        public async Task<List<TemporadaModel>> GetAllTemporadas()
        {
            return await _dbContext.Temporadas.ToListAsync();
        }
    }
}
