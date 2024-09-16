namespace ApiSSK.Repositories.Interfaces
{
    public interface ICalendarioRepository
    {
        Task<List<CalendarioModel>> GetAllCalendarios();

        //buscar por id
        //adicionar
        //modificar
        //deletar
    }
}
