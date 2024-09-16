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
    }
}
