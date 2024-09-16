using ApiSSK.Data;
using ApiSSK.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ApiSSK.Repositories
{
    public class StatusRepository : IStatusRepository
    {
        private readonly DataContext _dbContext;
        public StatusRepository(DataContext dataContext)
        {
            _dbContext = dataContext;
        }

        public async Task<List<StatusModel>> GetAllStatus()
        {
            return await _dbContext.Status.ToListAsync();
        }
    }
}
