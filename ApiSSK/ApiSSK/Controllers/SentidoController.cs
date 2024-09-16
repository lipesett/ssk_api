using Microsoft.AspNetCore.Mvc;

namespace ApiSSK.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SentidoController : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<List<Sentido>>> GetAllSentidos()
        {
            var sentidos = new List<Sentido>()
            {
                new Sentido()
                {
                    SenId = 1,
                    SenDesc = "Horário"
                },
                new Sentido()
                {
                    SenId = 2,
                    SenDesc = "Anti-Horário"
                }
            };

            return Ok(sentidos);
        }
    }
}
