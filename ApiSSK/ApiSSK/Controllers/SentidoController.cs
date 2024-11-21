using ApiSSK.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ApiSSK.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SentidoController : ControllerBase
    {
        private readonly ISentidoRepository _sentidoRepository;

        public SentidoController(ISentidoRepository sentidoRepository)
        {
            _sentidoRepository = sentidoRepository;
        }

        [HttpGet]
        public async Task<ActionResult<List<SentidoModel>>> GetAllSentidos()
        {
            return await _sentidoRepository.GetAllSentidos();
        }
    }
}