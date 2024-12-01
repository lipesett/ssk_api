using ApiSSK.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ApiSSK.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalendarioController : ControllerBase
    {
        private readonly ICalendarioRepository _calendarioRepository;

        public CalendarioController(ICalendarioRepository calendarioRepository)
        {
            _calendarioRepository = calendarioRepository;
        }

        [HttpGet]
        public async Task<ActionResult<List<CalendarioModel>>> GetAllCalendarios()
        {
            return await _calendarioRepository.GetAllCalendarios();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<CalendarioModel>> GetCalendarioById(int id)
        {
            return await _calendarioRepository.GetCalendarioById(id);
        }

        [HttpPost]
        public async Task<ActionResult<CalendarioModel>> AdicionarCalendario([FromBody] CalendarioModel calendarioModel)
        {
            return await _calendarioRepository.AdicionarCalendario(calendarioModel);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<CalendarioModel>> AtualizarCalendario([FromBody] CalendarioModel calendarioModel, int id)
        {
            calendarioModel.Id = id;
            return await _calendarioRepository.AtualizarCalendario(calendarioModel, id);
        }

        [HttpDelete("{id}")]
        public async Task<bool> DeletarCalendario(int id)
        {
            return await _calendarioRepository.DeletarCalendario(id);
        }
    }
}