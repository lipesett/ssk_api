namespace ApiSSK.Repositories.Interfaces
{
    public interface ISentidoRepository
    {
        Task<List<SentidoModel>> GetAllSentidos();
        Task<SentidoModel> GetSentidoById(int id);
        Task<SentidoModel> AdicionarSentido(SentidoModel sentidoModel);
        Task<SentidoModel> AtualizarSentido(SentidoModel sentidoModel, int id);
        Task<bool> DeletarSentido(int id);
    }
}