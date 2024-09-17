namespace ApiSSK.Repositories.Interfaces
{
    public interface IStatusRepository
    {
        Task<List<StatusModel>> GetAllStatus();
        Task<StatusModel> GetStatusById(int id);
        Task<StatusModel> AdicionarStatus(StatusModel statusModel);
        Task<StatusModel> AtualizarStatus(StatusModel statusModel, int id);
        Task<bool> DeletarStatus(int id);
    }
}