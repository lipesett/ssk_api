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

        public async Task<DivisaoModel> AdicionarDivisao(DivisaoModel divisaoModel)
        {
            await _dbContext.Divisoes.AddAsync(divisaoModel);
            await _dbContext.SaveChangesAsync();
            
            return divisaoModel;
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

        public async Task<DivisaoModel> GetDivisaoById(int id)
        {
            return await _dbContext.Divisoes.FindAsync(id);
        }
    }
}