namespace ApiSSK.Repositories.Interfaces
{
    public interface IPontuacaoPilotoEtapaRepository
    {
        Task<List<PontuacaoPilotoEtapaModel>> GetAllPontuacaoPilotoEtapas();
        Task<PontuacaoPilotoEtapaModel> GetPontuacaoPilotoEtapaById(int id);
        Task<PontuacaoPilotoEtapaModel> AdicionarPontuacaoPilotoEtapa(PontuacaoPilotoEtapaModel pontuacaoPilotoEtapaModel);
        Task<PontuacaoPilotoEtapaModel> AtualizarPontuacaoPilotoEtapa(PontuacaoPilotoEtapaModel pontuacaoPilotoEtapaModel, int id);
        Task<bool> DeletarPontuacaoPilotoEtapa(int id);
    }
}