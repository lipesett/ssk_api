namespace ApiSSK.Repositories.Interfaces
{
    public interface IClimaRepository
    {
        Task<List<ClimaModel>> GetAllClimas();
        Task<ClimaModel> GetClimaById(int id);
        Task<ClimaModel> AdicionarClima(ClimaModel climaModel);
        Task<ClimaModel> AtualizarClima(ClimaModel climaModel, int id);
        Task<bool> DeletarClima(int id);
    }
}