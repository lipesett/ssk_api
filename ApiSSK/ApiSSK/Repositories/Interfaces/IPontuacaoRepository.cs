namespace ApiSSK.Repositories.Interfaces
{
    public interface IPontuacaoRepository
    {
        Task<List<PontuacaoModel>> GetAllPontuacoes();

        //buscar por id
        //adicionar
        //modificar
        //deletar
    }
}
