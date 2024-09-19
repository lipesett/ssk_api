using ApiSSK.Data;
using ApiSSK.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ApiSSK.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly DataContext _dbContext;
        public CategoriaRepository(DataContext dataContext)
        {
            _dbContext = dataContext;
        }

        public Task<CategoriaModel> AdicionarCategoria(CategoriaModel categoriaModel)
        {
            throw new NotImplementedException();
        }

        public Task<CategoriaModel> AtualizarCategoria(CategoriaModel categoriaModel, int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeletarCategoria(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<CategoriaModel>> GetAllCategorias()
        {
            return await _dbContext.Categorias.ToListAsync();
        }

        public Task<CategoriaModel> GetCategoriaById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
