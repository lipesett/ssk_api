using ApiSSK.Data;
using ApiSSK.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ApiSSK.Repositories
{
    public class KartodromoRepository : IKartodromoRepository
    {
        private readonly DataContext _dbContext;
        public KartodromoRepository(DataContext dataContext)
        {
            _dbContext = dataContext;
        }

        public async Task<List<KartodromoModel>> GetAllKartodromos()
        {
            return await _dbContext.Kartodromos.ToListAsync();
        }
    }
}