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
            List<ClimaModel> climas = await _climaRepository.GetAllClimas();
            return Ok(climas);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ClimaModel>> GetClimaById(int id)
        {
            ClimaModel clima = await _climaRepository.GetClimaById(id);
            return Ok(clima);
        }

        [HttpPost]
        public async Task<ActionResult<ClimaModel>> AdicionarClima([FromBody] ClimaModel climaModel)
        {
            ClimaModel clima = await _climaRepository.AdicionarClima(climaModel);
            return Ok(clima);
        }

        [HttpPost("{id}")]
        public async Task<ActionResult<ClimaModel>> AtualizarClima([FromBody] ClimaModel climaModel, int id)
        {
            climaModel.Id = id;
            ClimaModel clima = await _climaRepository.AtualizarClima(climaModel, id);
            return Ok(clima);
        }

        [HttpDelete]
        public async Task<ActionResult<ClimaModel>> DeletarClima(int id)
        {
            bool deletado = await _climaRepository.DeletarClima(id);
            return Ok(deletado);
        }
    }
}