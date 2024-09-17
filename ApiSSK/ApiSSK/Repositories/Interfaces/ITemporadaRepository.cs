namespace ApiSSK.Repositories.Interfaces
{
    public interface ITemporadaRepository
    {
        Task<List<TemporadaModel>> GetAllTemporadas();
        Task<TemporadaModel> GetTemporadaById(int id);
        Task<TemporadaModel> AdicionarTemporada(TemporadaModel temporada);
        Task<TemporadaModel> AtualizarTemporada(TemporadaModel temporada, int id);
        Task<bool> DeletarTemporada(int id);
    }
}