namespace ApiSSK.Repositories.Interfaces
{
    public interface IPilotoRepository
    {
        Task<List<PilotoModel>> GetAllPilotos();
        Task<PilotoModel> GetPilotoById(int id);
        Task<PilotoModel> AdicionarPiloto(PilotoModel pilotoModel);
        Task<PilotoModel> AtualizarPiloto(PilotoModel pilotoModel, int id);
        Task<bool> DeletarPiloto(int id);
    }
}