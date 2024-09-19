using ApiSSK.Data;
using ApiSSK.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ApiSSK.Repositories
{
    public class PontuacaoPilotoEtapaRepository : IPontuacaoPilotoEtapaRepository
    {
        private readonly DataContext _dbContext;
        public PontuacaoPilotoEtapaRepository(DataContext dataContext)
        {
            _dbContext = dataContext;
        }

        public Task<PontuacaoPilotoEtapaModel> AdicionarPontuacaoPilotoEtapa(PontuacaoPilotoEtapaModel pontuacaoPilotoEtapaModel)
        {
            throw new NotImplementedException();
        }

        public Task<PontuacaoPilotoEtapaModel> AtualizarPontuacaoPilotoEtapa(PontuacaoPilotoEtapaModel pontuacaoPilotoEtapaModel, int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeletarPontuacaoPilotoEtapa(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<PontuacaoPilotoEtapaModel>> GetAllPontuacaoPilotoEtapas()
        {
            return await _dbContext.PontuacoesEtapa.ToListAsync();
        }

        public Task<PontuacaoPilotoEtapaModel> GetPontuacaoPilotoEtapaById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
