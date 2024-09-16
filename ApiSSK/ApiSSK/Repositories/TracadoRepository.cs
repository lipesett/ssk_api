using ApiSSK.Data;
using ApiSSK.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ApiSSK.Repositories
{
    public class TracadoRepository : ITracadoRepository
    {
        private readonly DataContext _dbContext;
        public TracadoRepository(DataContext dataContext)
        {
            _dbContext = dataContext;
        }

        public async Task<List<TracadoModel>> GetAllTracados()
        {
            return await _dbContext.Tracados.ToListAsync();
        }
    }
}
