namespace ApiSSK.Repositories.Interfaces
{
    public interface IMelhorVoltaRepository
    {
        Task<List<MelhorVoltaModel>> GetAllMelhoresVoltas();
        Task<MelhorVoltaModel> GetMelhorVoltaById(int id);
        Task<MelhorVoltaModel> AdicionarMelhorVolta(MelhorVoltaModel melhorVoltaModel);
        Task<MelhorVoltaModel> AtualizarMelhorVolta(MelhorVoltaModel melhorVoltaModel, int id);
        Task<bool> DeletarMelhorVolta(int id);
    }
}
