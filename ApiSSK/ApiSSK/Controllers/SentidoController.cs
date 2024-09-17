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
                    SenId = 1,
                    SenDesc = "Horário"
                },
                new SentidoModel()
                {
                    SenId = 2,
                    SenDesc = "Anti-Horário"
                }
            };

            return Ok(sentidos);
        }
    }
}
