using ApiSSK.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ApiSSK.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TracadoController : ControllerBase
    {
        private readonly ITracadoRepository _tracadoRepository;

        public TracadoController(ITracadoRepository tracadoRepository)
        {
            _tracadoRepository = tracadoRepository;
        }

        [HttpGet]
        public async Task<ActionResult<List<TracadoModel>>> GetAllTracados()
        {
            return await _tracadoRepository.GetAllTracados();
        }

        [HttpPost]
        public async Task<ActionResult<TracadoModel>> AddTracado(TracadoModel divisao)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            return await _tracadoRepository.AdicionarTracado(divisao);
        }
    }
}