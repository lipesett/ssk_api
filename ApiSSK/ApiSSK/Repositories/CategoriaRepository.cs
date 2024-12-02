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

        public async Task<List<CategoriaModel>> GetAllCategorias()
        {
            return await _dbContext.Categorias.ToListAsync();
        }

        public async Task<CategoriaModel> GetCategoriaById(int id)
        {
            var categoria = await _dbContext.Categorias.FirstOrDefaultAsync(c => c.Id == id);

            if (categoria == null)
            {
                throw new Exception($"Categoria de {id} não foi encontrada no banco de dados.");
            }

            return categoria;
        }

        public async Task<CategoriaModel> AdicionarCategoria(CategoriaModel categoriaModel)
        {
            await _dbContext.Categorias.AddAsync(categoriaModel);
            await _dbContext.SaveChangesAsync();

            return categoriaModel;
        }

        public async Task<CategoriaModel> AtualizarCategoria(CategoriaModel categoriaModel, int id)
        {
            CategoriaModel categoriaId = await GetCategoriaById(id);

            categoriaId.Nome = categoriaModel.Nome;
            categoriaId.Status = categoriaModel.Status;

            _dbContext.Update(categoriaId);
            await _dbContext.SaveChangesAsync();

            return categoriaId;
        }

        public async Task<bool> DeletarCategoria(int id)
        {
            CategoriaModel categoriaId = await GetCategoriaById(id);

            _dbContext.Remove(categoriaId);
            await _dbContext.SaveChangesAsync();

            return true;
        }
    }
}
