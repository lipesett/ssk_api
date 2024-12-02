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

        public async Task<List<TracadoModel>> GetAllTracados()
        {
            return await _dbContext.Tracados.ToListAsync();
        }

        public async Task<TracadoModel> GetTracadoById(int id)
        {
            return await _dbContext.Tracados.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<TracadoModel> AdicionarTracado(TracadoModel tracado)
        {
            await _dbContext.Tracados.AddAsync(tracado);
            await _dbContext.SaveChangesAsync();

            return tracado;
        }

        public async Task<TracadoModel> AtualizarTracado(TracadoModel tracado, int id)
        {
            TracadoModel tracadoId = await GetTracadoById(id);

            if (tracadoId == null)
            {
                throw new Exception($"Traçado para o ID: {id} não encontrado.");
            }

            tracadoId.Nome = tracado.Nome;
            tracadoId.DataEstreia = tracado.DataEstreia;
            tracadoId.KartodromoId = tracado.KartodromoId;
            tracadoId.ClimaId = tracado.ClimaId;
            tracadoId.MvEstreiaId = tracado.MvEstreiaId;
            tracadoId.MvRecordId = tracado.MvRecordId;
            tracadoId.Img = tracado.Img;
            tracadoId.Sentido = tracado.Sentido;

            _dbContext.Tracados.Update(tracadoId);
            await _dbContext.SaveChangesAsync();

            return tracadoId;
        }

        public async Task<bool> DeletarTracado(int id)
        {
            TracadoModel tracadoId = await GetTracadoById(id);

            if (tracadoId == null)
            {
                throw new Exception($"Traçado para o ID: {id} não encontrado.");
            }

            _dbContext.Tracados.Remove(tracadoId);
            await _dbContext.SaveChangesAsync();

            return true;
        }
    }
}