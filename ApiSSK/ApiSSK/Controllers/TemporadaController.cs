using ApiSSK.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ApiSSK.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TemporadaController : ControllerBase
    {
        private readonly ITemporadaRepository _temporadaRepository;

        public TemporadaController(ITemporadaRepository temporadaRepository)
        {
            _temporadaRepository = temporadaRepository;
        }

        [HttpGet]
        public async Task<ActionResult<List<TemporadaModel>>> GetAllTemporadas()
        {
            return await _temporadaRepository.GetAllTemporadas();
        }
    }
}