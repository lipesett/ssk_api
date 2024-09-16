namespace ApiSSK.Repositories.Interfaces
{
    public interface IKartodromoRepository
    {
        Task<List<KartodromoModel>> GetAllKartodromos();

        //buscar por id
        //adicionar
        //modificar
        //deletar
    }
}
