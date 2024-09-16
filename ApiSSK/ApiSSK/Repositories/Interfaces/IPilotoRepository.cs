namespace ApiSSK.Repositories.Interfaces
{
    public interface IPilotoRepository
    {
        Task<List<PilotoModel>> GetAllPilotos();

        //buscar por id
        //adicionar
        //modificar
        //deletar
    }
}
