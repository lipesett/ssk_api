using Microsoft.AspNetCore.Mvc;

namespace ApiSSK.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClimaController : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<List<ClimaModel>>> GetAllClimas()
        {
            var climas = new List<ClimaModel>()
            {
                new ClimaModel()
                {
                    CliId = 1,
                    CliDesc = "Seco"
                },
                new ClimaModel()
                {
                    CliId = 2,
                    CliDesc = "Misto"
                },
                new ClimaModel()
                {
                    CliId = 3,
                    CliDesc = "Chuva"
                }
            };

            return Ok(climas);
        }
    }
}
