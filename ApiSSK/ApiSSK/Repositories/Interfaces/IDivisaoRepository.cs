namespace ApiSSK.Repositories.Interfaces
{
    public interface IDivisaoRepository
    {
        Task<List<DivisaoModel>> GetAllDivisoes();

        //buscar por id
        //adicionar
        //modificar
        //deletar
    }
}
