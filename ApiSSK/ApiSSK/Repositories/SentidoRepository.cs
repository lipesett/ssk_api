using ApiSSK.Data;
using ApiSSK.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ApiSSK.Repositories
{
    public class SentidoRepository : ISentidoRepository
    {
        private readonly DataContext _dbContext;
        public SentidoRepository(DataContext dataContext)
        {
            _dbContext = dataContext;
        }

        public Task<SentidoModel> AdicionarSentido(SentidoModel sentidoModel)
        {
            throw new NotImplementedException();
        }

        public Task<SentidoModel> AtualizarSentido(SentidoModel sentidoModel, int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeletarSentido(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<SentidoModel>> GetAllSentidos()
        {
            return await _dbContext.Sentidos.ToListAsync();
        }

        public Task<SentidoModel> GetSentidoById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
