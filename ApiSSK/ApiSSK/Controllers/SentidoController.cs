using Microsoft.AspNetCore.Mvc;

namespace ApiSSK.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SentidoController : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<List<SentidoModel>>> GetAllSentidos()
        {
            var sentidos = new List<SentidoModel>()
            {
                new SentidoModel()
                {
                    Id = 1,
                    Descricao = "Horário"
                },
                new SentidoModel()
                {
                    Id = 2,
                    Descricao = "Anti-Horário"
                }
            };

            return Ok(sentidos);
        }
    }
}
