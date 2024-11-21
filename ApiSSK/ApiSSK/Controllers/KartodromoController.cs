using ApiSSK.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ApiSSK.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KartodromoController : ControllerBase
    {
        private readonly IKartodromoRepository _kartodromoRepository;

        public KartodromoController(IKartodromoRepository kartodromoRepository)
        {
            _kartodromoRepository = kartodromoRepository;
        }

        [HttpGet]
        public async Task<ActionResult<List<KartodromoModel>>> GetAllKartodromos()
        {
            return await _kartodromoRepository.GetAllKartodromos();
        }
    }
}