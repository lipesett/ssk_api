using ApiSSK.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ApiSSK.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PilotoController : ControllerBase
    {
        private readonly IPilotoRepository _pilotoRepository;

        public PilotoController(IPilotoRepository pilotoRepository)
        {
            _pilotoRepository = pilotoRepository;
        }

        [HttpGet]
        public async Task<ActionResult<List<PilotoModel>>> GetAllPilotos()
        {
            return await _pilotoRepository.GetAllPilotos();
        }
    }
}