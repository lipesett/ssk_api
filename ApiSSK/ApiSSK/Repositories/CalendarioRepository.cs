using ApiSSK.Data;
using ApiSSK.Repositories.Interfaces;
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
    }
}
