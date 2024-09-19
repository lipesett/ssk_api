using ApiSSK.Data;
using ApiSSK.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ApiSSK.Repositories
{
    public class PontuacaoRepository : IPontuacaoRepository
    {
        private readonly DataContext _dbContext;
        public PontuacaoRepository(DataContext dataContext)
        {
            _dbContext = dataContext;
        }

        public Task<PontuacaoModel> AdicionarPontuacao(PontuacaoModel pontuacaoModel)
        {
            throw new NotImplementedException();
        }

        public Task<PontuacaoModel> AtualizarPontuacao(PontuacaoModel pontuacaoModel, int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeletarPontuacao(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<PontuacaoModel>> GetAllPontuacoes()
        {
            return await _dbContext.Pontuacoes.ToListAsync();
        }

        public Task<PontuacaoModel> GetPontuacaoById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
