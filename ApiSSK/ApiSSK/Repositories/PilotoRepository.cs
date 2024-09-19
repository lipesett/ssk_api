using ApiSSK.Data;
using ApiSSK.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ApiSSK.Repositories
{
    public class PilotoRepository : IPilotoRepository
    {
        private readonly DataContext _dbContext;
        public PilotoRepository(DataContext dataContext)
        {
            _dbContext = dataContext;
        }

        public Task<PilotoModel> AdicionarPiloto(PilotoModel pilotoModel)
        {
            throw new NotImplementedException();
        }

        public Task<PilotoModel> AtualizarPiloto(PilotoModel pilotoModel, int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeletarPiloto(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<PilotoModel>> GetAllPilotos()
        {
            return await _dbContext.Pilotos.ToListAsync();
        }

        public Task<PilotoModel> GetPilotoById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
