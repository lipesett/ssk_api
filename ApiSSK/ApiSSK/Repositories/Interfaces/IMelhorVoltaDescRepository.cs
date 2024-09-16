namespace ApiSSK.Repositories.Interfaces
{
    public interface IMelhorVoltaDescRepository
    {
        Task<List<MelhorVoltaDescModel>> GetAllMVDescricoes();

        //buscar por id
        //adicionar
        //modificar
        //deletar
    }
}
