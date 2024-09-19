using ApiSSK.Data;
using ApiSSK.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ApiSSK.Repositories
{
    public class StatusRepository : IStatusRepository
    {
        private readonly DataContext _dbContext;
        public StatusRepository(DataContext dataContext)
        {
            _dbContext = dataContext;
        }

        public Task<StatusModel> AdicionarStatus(StatusModel statusModel)
        {
            throw new NotImplementedException();
        }

        public Task<StatusModel> AtualizarStatus(StatusModel statusModel, int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeletarStatus(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<StatusModel>> GetAllStatus()
        {
            return await _dbContext.Status.ToListAsync();
        }

        public Task<StatusModel> GetStatusById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
