using ApiSSK.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ApiSSK.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClimaController : ControllerBase
    {
        private readonly IClimaRepository _climaRepository;

        public ClimaController(IClimaRepository climaRepository)
        {
            _climaRepository = climaRepository;
        }

        [HttpGet]
        public async Task<ActionResult<List<ClimaModel>>> GetAllClimas()
        {
            return await _climaRepository.GetAllClimas();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ClimaModel>> GetClimaById(int id)
        {
            return await _climaRepository.GetClimaById(id);
        }
    }
}