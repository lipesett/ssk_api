namespace ApiSSK.Repositories.Interfaces
{
    public interface ITracadoRepository
    {
        Task<List<TracadoModel>> GetAllTracados();

        //buscar por id
        //adicionar
        //modificar
        //deletar
    }
}
