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
            var calendario = await _dbContext.Calendarios
                .Include(c => c.Tracado)
                .Include(c => c.Temporada)
                .Include(c => c.Piloto)
                .FirstOrDefaultAsync(c => c.Id == id);

            if (calendario == null)
            {
                throw new Exception($"Calendário de {id} não foi encontrado no banco de dados.");
            }

            return calendario;
        }

        public async Task<CalendarioModel> AdicionarCalendario(CalendarioModel calendarioModel)
        {
            await _dbContext.Calendarios.AddAsync(calendarioModel);
            await _dbContext.SaveChangesAsync();

            return calendarioModel;
        }

        public async Task<CalendarioModel> AtualizarCalendario(CalendarioModel calendarioModel, int id)
        {
            CalendarioModel calendarioId = await GetCalendarioById(id);

            calendarioId.NomeEtapa = calendarioModel.NomeEtapa;
            calendarioId.NumEtapa = calendarioModel.NumEtapa;
            calendarioId.Dia = calendarioModel.Dia;
            calendarioId.Mes = calendarioModel.Mes;
            calendarioId.Ano = calendarioModel.Ano;
            calendarioId.DataCompleta = calendarioModel.DataCompleta;
            calendarioId.Horario = calendarioModel.Horario;
            calendarioId.PtsDisputados = calendarioModel.PtsDisputados;
            calendarioId.EtapaRealizada = calendarioModel.EtapaRealizada;
            calendarioId.TracadoId = calendarioModel.TracadoId;
            calendarioId.TemporadaId = calendarioModel.TemporadaId;
            calendarioId.PilotoId = calendarioModel.PilotoId;

            _dbContext.Calendarios.Update(calendarioId);
            await _dbContext.SaveChangesAsync();

            return calendarioId;
        }

        public async Task<bool> DeletarCalendario(int id)
        {
            CalendarioModel calendarioId = await GetCalendarioById(id);

            _dbContext.Calendarios.Remove(calendarioId);
            await _dbContext.SaveChangesAsync();

            return true;
        }
    }
}
