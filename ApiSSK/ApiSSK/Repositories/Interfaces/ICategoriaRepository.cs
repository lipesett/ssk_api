namespace ApiSSK.Repositories.Interfaces
{
    public interface ICategoriaRepository
    {
        Task<List<CategoriaModel>> GetAllCategorias();

        //buscar por id
        //adicionar
        //modificar
        //deletar
    }
}
