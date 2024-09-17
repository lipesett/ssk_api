namespace ApiSSK.Repositories.Interfaces
{
    public interface IInscricaoRepository
    {
        Task<List<InscricaoModel>> GetAllInscricoes();
        Task<InscricaoModel> GetInscricaoById(int id);
        Task<InscricaoModel> AdicionarInscricao(InscricaoModel inscricaoModel);
        Task<InscricaoModel> AtualizarInscricao(InscricaoModel inscricaoModel, int id);
        Task<bool> DeletarInscricao(int id);
    }
}