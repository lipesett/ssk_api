namespace ApiSSK.Repositories.Interfaces
{
    public interface IMelhorVoltaDescRepository
    {
        Task<List<MelhorVoltaDescModel>> GetAllMVDescricoes();
        Task<MelhorVoltaDescModel> GetMVDescricaoById(int id);
        Task<MelhorVoltaDescModel> AdicionarMVDescricao(MelhorVoltaDescModel melhorVoltaDescModel);
        Task<MelhorVoltaDescModel> AtualizarMVDescricao(MelhorVoltaDescModel melhorVoltaDescModel, int id);
        Task<bool> DeletarMVDescricao(int id);
    }
}