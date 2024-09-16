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
    }
}
