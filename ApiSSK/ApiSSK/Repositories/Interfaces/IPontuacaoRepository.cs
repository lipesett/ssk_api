namespace ApiSSK.Repositories.Interfaces
{
    public interface IPontuacaoRepository
    {
        Task<List<PontuacaoModel>> GetAllPontuacoes();
        Task<PontuacaoModel> GetPontuacaoById(int id);
        Task<PontuacaoModel> AdicionarPontuacao(PontuacaoModel pontuacaoModel);
        Task<PontuacaoModel> AtualizarPontuacao(PontuacaoModel pontuacaoModel, int id);
        Task<bool> DeletarPontuacao(int id);
    }
}