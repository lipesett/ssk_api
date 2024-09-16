namespace ApiSSK.Repositories.Interfaces
{
    public interface IInscricaoRepository
    {
        Task<List<InscricaoModel>> GetAllInscricoes();

        //buscar por id
        //adicionar
        //modificar
        //deletar
    }
}
