namespace ApiSSK.Repositories.Interfaces
{
    public interface ICategoriaRepository
    {
        Task<List<CategoriaModel>> GetAllCategorias();
        Task<CategoriaModel> GetCategoriaById(int id);
        Task<CategoriaModel> AdicionarCategoria(CategoriaModel categoriaModel);
        Task<CategoriaModel> AtualizarCategoria(CategoriaModel categoriaModel, int id);
        Task<bool> DeletarCategoria(int id);
    }
}