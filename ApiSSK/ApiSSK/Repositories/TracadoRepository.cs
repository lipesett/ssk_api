using ApiSSK.Data;
using ApiSSK.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ApiSSK.Repositories
{
    public class TracadoRepository : ITracadoRepository
    {
        private readonly DataContext _dbContext;
        public TracadoRepository(DataContext dataContext)
        {
            _dbContext = dataContext;
        }

        public Task<TracadoModel> AdicionarTracado(TracadoModel tracado)
        {
            throw new NotImplementedException();
        }

        public Task<TracadoModel> AtualizarTracado(TracadoModel tracado, int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeletarTracado(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<TracadoModel>> GetAllTracados()
        {
            return await _dbContext.Tracados.ToListAsync();
        }

        public Task<TracadoModel> GetTracadoById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
