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

        public Task<MelhorVoltaDescModel> AdicionarMVDescricao(MelhorVoltaDescModel melhorVoltaDescModel)
        {
            throw new NotImplementedException();
        }

        public Task<MelhorVoltaDescModel> AtualizarMVDescricao(MelhorVoltaDescModel melhorVoltaDescModel, int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeletarMVDescricao(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<MelhorVoltaDescModel>> GetAllMVDescricoes()
        {
            return await _dbContext.MelhoresVoltasDesc.ToListAsync();
        }

        public Task<MelhorVoltaDescModel> GetMVDescricaoById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
