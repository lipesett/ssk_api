namespace ApiSSK.Repositories.Interfaces
{
    public interface IPontuacaoPilotoEtapaRepository
    {
        Task<List<PontuacaoPilotoEtapaModel>> GetAllPontuacaoPilotoEtapas();

        //buscar por id
        //adicionar
        //modificar
        //deletar
    }
}
