using ApiSSK.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ApiSSK.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MelhorVoltaDescController : ControllerBase
    {
        private readonly IMelhorVoltaDescRepository _mvDescRepository;

        public MelhorVoltaDescController(IMelhorVoltaDescRepository mvDescRepository)
        {
            _mvDescRepository = mvDescRepository;
        }


        [HttpGet]
        public async Task<ActionResult<List<MelhorVoltaDescModel>>> GetAllMelhoresVoltasDesc()
        {
            return await _mvDescRepository.GetAllMVDescricoes();
        }
    }
}