using ApiSSK.Data;
using ApiSSK.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ApiSSK.Repositories
{
    public class InscricaoRepository : IInscricaoRepository
    {
        private readonly DataContext _dbContext;
        public InscricaoRepository(DataContext dataContext)
        {
            _dbContext = dataContext;
        }

        public Task<InscricaoModel> AdicionarInscricao(InscricaoModel inscricaoModel)
        {
            throw new NotImplementedException();
        }

        public Task<InscricaoModel> AtualizarInscricao(InscricaoModel inscricaoModel, int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeletarInscricao(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<InscricaoModel>> GetAllInscricoes()
        {
            return await _dbContext.Inscricoes.ToListAsync();
        }

        public Task<InscricaoModel> GetInscricaoById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
