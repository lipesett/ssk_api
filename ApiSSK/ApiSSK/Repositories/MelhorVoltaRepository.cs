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

        public Task<MelhorVoltaModel> AdicionarMelhorVolta(MelhorVoltaModel melhorVoltaModel)
        {
            throw new NotImplementedException();
        }

        public Task<MelhorVoltaModel> AtualizarMelhorVolta(MelhorVoltaModel melhorVoltaModel, int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeletarMelhorVolta(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<MelhorVoltaModel>> GetAllMelhoresVoltas()
        {
            return await _dbContext.MelhoresVoltas.ToListAsync();
        }

        public Task<MelhorVoltaModel> GetMelhorVoltaById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
