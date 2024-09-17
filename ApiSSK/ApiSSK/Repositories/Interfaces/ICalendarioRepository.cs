namespace ApiSSK.Repositories.Interfaces
{
    public interface ICalendarioRepository
    {
        Task<List<CalendarioModel>> GetAllCalendarios();
        Task<CalendarioModel> GetCalendarioById(int id);
        Task<CalendarioModel> AdicionarCalendario(CalendarioModel calendarioModel);
        Task<CalendarioModel> AtualizarCalendario(CalendarioModel calendarioModel, int id);
        Task<bool> DeletarCalendario(int id);
    }
}