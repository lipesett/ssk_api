using ApiSSK.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ApiSSK.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MelhorVoltaController : ControllerBase
    {
        private readonly IMelhorVoltaRepository _mvRepository;

        public MelhorVoltaController(IMelhorVoltaRepository mvRepository)
        {
            _mvRepository = mvRepository;
        }

        [HttpGet]
        public async Task<ActionResult<List<MelhorVoltaModel>>> GetAllMelhoresVoltas()
        {
            return await _mvRepository.GetAllMelhoresVoltas();
        }
    }
}