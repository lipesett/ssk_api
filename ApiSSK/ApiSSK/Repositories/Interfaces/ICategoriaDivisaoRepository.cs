namespace ApiSSK.Repositories.Interfaces
{
    public interface ICategoriaDivisaoRepository
    {
        Task<List<CategoriaDivisaoModel>> GetAllCategoriasDivisoes();
        Task<CategoriaDivisaoModel> GetCategoriaDivisaoById(int id);
        Task<CategoriaDivisaoModel> AdicionarCategoriaDivisao(CategoriaDivisaoModel categoriaDivisaoModel);
        Task<bool> DeletarCategoriaDivisao(int id);
    }
}