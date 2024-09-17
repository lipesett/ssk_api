namespace ApiSSK.Repositories.Interfaces
{
    public interface ITracadoRepository
    {
        Task<List<TracadoModel>> GetAllTracados();

        Task<TracadoModel> GetTracadoById(int id);
        Task<TracadoModel> AdicionarTracado(TracadoModel tracado);
        Task<TracadoModel> AtualizarTracado(TracadoModel tracado, int id);
        Task<bool> DeletarTracado(int id);
    }
}