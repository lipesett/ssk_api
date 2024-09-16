namespace ApiSSK.Repositories.Interfaces
{
    public interface ISentidoRepository
    {
        Task<List<SentidoModel>> GetAllSentidos();

        //buscar por id
        //adicionar
        //modificar
        //deletar
    }
}
