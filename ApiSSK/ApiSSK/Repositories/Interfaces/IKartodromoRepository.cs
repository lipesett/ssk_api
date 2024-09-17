namespace ApiSSK.Repositories.Interfaces
{
    public interface IKartodromoRepository
    {
        Task<List<KartodromoModel>> GetAllKartodromos();
        Task<KartodromoModel> GetKartodromoById(int id);
        Task<KartodromoModel> AdicionarKartodromo(KartodromoModel kartodromoModel);
        Task<KartodromoModel> AtualizarKartodromo(KartodromoModel kartodromoModel, int id);
        Task<bool> DeletarKartodromo(int id);
    }
}