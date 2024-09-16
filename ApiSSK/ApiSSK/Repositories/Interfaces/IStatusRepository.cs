namespace ApiSSK.Repositories.Interfaces
{
    public interface IStatusRepository
    {
        Task<List<StatusModel>> GetAllStatus();

        //buscar por id
        //adicionar
        //modificar
        //deletar
    }
}
