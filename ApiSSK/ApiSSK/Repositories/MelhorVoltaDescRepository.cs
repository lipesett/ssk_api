using ApiSSK.Data;
using ApiSSK.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ApiSSK.Repositories
{
    public class MelhorVoltaDescRepository : IMelhorVoltaDescRepository
    {
        private readonly DataContext _dbContext;
        public MelhorVoltaDescRepository(DataContext dataContext)
        {
            _dbContext = dataContext;
        }

        public async Task<List<MelhorVoltaDescModel>> GetAllMVDescricoes()
        {
            return await _dbContext.MelhoresVoltasDesc.ToListAsync();
        }
    }
}
