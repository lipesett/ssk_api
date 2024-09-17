namespace ApiSSK.Repositories.Interfaces
{
    public interface IDivisaoRepository
    {
        Task<List<DivisaoModel>> GetAllDivisoes();
        Task<DivisaoModel> GetDivisaoById(int id);
        Task<DivisaoModel> AdicionarDivisao(DivisaoModel DivisaoModel);
        Task<DivisaoModel> AtualizarDivisao(DivisaoModel DivisaoModel, int id);
        Task<bool> DeletarDivisao(int id);
    }
}