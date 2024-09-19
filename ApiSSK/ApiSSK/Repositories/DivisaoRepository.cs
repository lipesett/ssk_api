using ApiSSK.Data;
using ApiSSK.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ApiSSK.Repositories
{
    public class DivisaoRepository : IDivisaoRepository
    {
        private readonly DataContext _dbContext;
        public DivisaoRepository(DataContext dataContext)
        {
            _dbContext = dataContext;
        }

        public Task<DivisaoModel> AdicionarDivisao(DivisaoModel DivisaoModel)
        {
            throw new NotImplementedException();
        }

        public Task<DivisaoModel> AtualizarDivisao(DivisaoModel DivisaoModel, int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeletarDivisao(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<DivisaoModel>> GetAllDivisoes()
        {
            return await _dbContext.Divisoes.ToListAsync();
        }

        public Task<DivisaoModel> GetDivisaoById(int id)
        {
            throw new NotImplementedException();
        }
    }
}