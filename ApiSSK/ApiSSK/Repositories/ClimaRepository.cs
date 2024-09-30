using ApiSSK.Data;
using ApiSSK.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ApiSSK.Repositories
{
    public class ClimaRepository : IClimaRepository
    {
        private readonly DataContext _dbContext;
        public ClimaRepository(DataContext dataContext)
        {
            _dbContext = dataContext;
        }

        public async Task<List<ClimaModel>> GetAllClimas()
        {
            return await _dbContext.Climas.ToListAsync();
        }

        public async Task<ClimaModel> GetClimaById(int id)
        {
            return await _dbContext.Climas.FirstOrDefaultAsync(x => x.CliId == id);
        }

        public async Task<ClimaModel> AdicionarClima(ClimaModel climaModel)
        {
            await _dbContext.Climas.AddAsync(climaModel);
            await _dbContext.SaveChangesAsync();

            return climaModel;
        }

        public async Task<ClimaModel> AtualizarClima(ClimaModel climaModel, int id)
        {
            ClimaModel climaId = await GetClimaById(id);

            if (climaId == null)
            {
                throw new Exception($"Clima para o ID: {id} não encontrado.");
            }

            climaId.CliDesc = climaModel.CliDesc;

            _dbContext.Climas.Update(climaId);
            await _dbContext.SaveChangesAsync();

            return climaId;

        }

        public async Task<bool> DeletarClima(int id)
        {
            ClimaModel climaId = await GetClimaById(id);

            if(climaId == null)
            {
                throw new Exception($"Clima para o ID: {id} não encontrado.");
            }

            _dbContext.Climas.Remove(climaId);
            await _dbContext.SaveChangesAsync();

            return true;
        }
    }
}