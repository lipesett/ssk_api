using ApiSSK.Data;
using ApiSSK.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ApiSSK.Repositories
{
    public class TemporadaRepository : ITemporadaRepository
    {
        private readonly DataContext _dbContext;
        public TemporadaRepository(DataContext dataContext)
        {
            _dbContext = dataContext;
        }

        public Task<TemporadaModel> AdicionarTemporada(TemporadaModel temporada)
        {
            throw new NotImplementedException();
        }

        public Task<TemporadaModel> AtualizarTemporada(TemporadaModel temporada, int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeletarTemporada(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<TemporadaModel>> GetAllTemporadas()
        {
            return await _dbContext.Temporadas.ToListAsync();
        }

        public Task<TemporadaModel> GetTemporadaById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
