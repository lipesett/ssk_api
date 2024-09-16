namespace ApiSSK.Repositories.Interfaces
{
    public interface ICategoriaDivisaoRepository
    {
        Task<List<CategoriaDivisaoModel>> GetAllCategoriasDivisoes();

        //buscar por id
        //adicionar
        //modificar
        //deletar
    }
}
