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
        public async Task<List<CategoriaDivisaoModel>> GetAllCategoriasDivisoes()
        {
            return await _dbContext.CategoriasDivisoes.ToListAsync();
        }

        public async Task<CategoriaDivisaoModel> GetCategoriaDivisaoById(int id)
        {
            return await _dbContext.CategoriasDivisoes.FirstOrDefaultAsync(x => x.CategoriaId == id);
        }

        public async Task<CategoriaDivisaoModel> AdicionarCategoriaDivisao(CategoriaDivisaoModel categoriaDivisaoModel)
        {
            await _dbContext.CategoriasDivisoes.AddAsync(categoriaDivisaoModel);
            await _dbContext.SaveChangesAsync();

            return categoriaDivisaoModel;
        }

        public async Task<bool> DeletarCategoriaDivisao(int id)
        {
            CategoriaDivisaoModel categoriaDivisaoModel = await GetCategoriaDivisaoById(id);

            if (categoriaDivisaoModel == null)
            {
                throw new Exception($"Clima para o ID: {id} não encontrado.");
            }

            _dbContext.CategoriasDivisoes.Remove(categoriaDivisaoModel);
            await _dbContext.SaveChangesAsync();

            return true; ;
        }
    }
}
