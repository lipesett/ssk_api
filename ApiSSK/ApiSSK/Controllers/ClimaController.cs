using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiSSK.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClimaController : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<List<Clima>>> GetAllClimas()
        {
            var climas = new List<Clima>()
            {
                new Clima()
                {
                    CliId = 1,
                    CliDesc = "Seco"
                },
                new Clima()
                {
                    CliId = 2,
                    CliDesc = "Misto"
                },
                new Clima()
                {
                    CliId = 3,
                    CliDesc = "Chuva"
                }
            };

            return Ok(climas);
        }
    }
}
