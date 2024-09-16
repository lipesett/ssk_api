using ApiSSK.Data;
using ApiSSK.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ApiSSK.Repositories
{
    public class SentidoRepository : ISentidoRepository
    {
        private readonly DataContext _dbContext;
        public SentidoRepository(DataContext dataContext)
        {
            _dbContext = dataContext;
        }

        public async Task<List<SentidoModel>> GetAllSentidos()
        {
            return await _dbContext.Sentidos.ToListAsync();
        }
    }
}
