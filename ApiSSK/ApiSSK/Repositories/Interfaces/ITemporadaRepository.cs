namespace ApiSSK.Repositories.Interfaces
{
    public interface ITemporadaRepository
    {
        Task<List<TemporadaModel>> GetAllTemporadas();

        //buscar por id
        //adicionar
        //modificar
        //deletar
    }
}
