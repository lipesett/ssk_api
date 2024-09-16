using ApiSSK.Data;
using ApiSSK.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ApiSSK.Repositories
{
    public class MelhorVoltaRepository : IMelhorVoltaRepository
    {
        private readonly DataContext _dbContext;
        public MelhorVoltaRepository(DataContext dataContext)
        {
            _dbContext = dataContext;
        }

        public async Task<List<MelhorVoltaModel>> GetAllMelhoresVoltas()
        {
            return await _dbContext.MelhoresVoltas.ToListAsync();
        }
    }
}
