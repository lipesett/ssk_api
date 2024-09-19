using ApiSSK.Data;
using ApiSSK.Repositories.Interfaces;
using Azure.Core;
using Microsoft.EntityFrameworkCore;

namespace ApiSSK.Repositories
{
    public class CalendarioRepository : ICalendarioRepository
    {
        private readonly DataContext _dbContext;
        public CalendarioRepository(DataContext dataContext)
        {
            _dbContext = dataContext;
        }

        public async Task<List<CalendarioModel>> GetAllCalendarios()
        {
            return await _dbContext.Calendarios.ToListAsync();
        }

        public async Task<CalendarioModel> GetCalendarioById(int id)
        {
            return await _dbContext.Calendarios.FirstOrDefaultAsync();
        }

        public Task<CalendarioModel> AdicionarCalendario(CalendarioModel calendarioModel)
        {
            throw new NotImplementedException();
        }

        public Task<CalendarioModel> AtualizarCalendario(CalendarioModel calendarioModel, int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeletarCalendario(int id)
        {
            throw new NotImplementedException();
        }
    }
}
