namespace ApiSSK.Repositories.Interfaces
{
    public interface IClimaRepository
    {
        Task<List<ClimaModel>> GetAllClimas();

        //buscar por id
        //adicionar
        //modificar
        //deletar
    }
}
