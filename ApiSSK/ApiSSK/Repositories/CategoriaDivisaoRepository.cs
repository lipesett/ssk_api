using ApiSSK.Data;
using ApiSSK.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ApiSSK.Repositories
{
    public class CategoriaDivisaoRepository : ICategoriaDivisaoRepository
    {
        private readonly DataContext _dbContext;
        public CategoriaDivisaoRepository(DataContext dataContext)
        {
            _dbContext = dataContext;
        }

        public Task<CategoriaDivisaoModel> AdicionarCategoriaDivisao(CategoriaDivisaoModel categoriaDivisaoModel)
        {
            throw new NotImplementedException();
        }

        public Task<CategoriaDivisaoModel> AtualizarCategoriaDivisao(CategoriaDivisaoModel categoriaDivisaoModel, int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeletarCategoriaDivisao(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<CategoriaDivisaoModel>> GetAllCategoriasDivisoes()
        {
            return await _dbContext.CategoriasDivisoes.ToListAsync();
        }

        public Task<CategoriaDivisaoModel> GetCategoriaDivisaoById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
