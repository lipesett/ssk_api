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

        public Task<KartodromoModel> AdicionarKartodromo(KartodromoModel kartodromoModel)
        {
            throw new NotImplementedException();
        }

        public Task<KartodromoModel> AtualizarKartodromo(KartodromoModel kartodromoModel, int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeletarKartodromo(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<KartodromoModel>> GetAllKartodromos()
        {
            return await _dbContext.Kartodromos.ToListAsync();
        }

        public Task<KartodromoModel> GetKartodromoById(int id)
        {
            throw new NotImplementedException();
        }
    }
}