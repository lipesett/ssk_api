using Microsoft.AspNetCore.Mvc;

namespace ApiSSK.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MelhorVoltaDescController : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<List<MelhorVoltaDescModel>>> GetAllMelhoresVoltasDesc()
        {
            var mv = new List<MelhorVoltaDescModel>()
            {
                new MelhorVoltaDescModel()
                {
                    Id = 1,
                    Descricao = "Estreia",
                },
                new MelhorVoltaDescModel()
                {
                    Id = 2,
                    Descricao = "Recorde",
                },
                new MelhorVoltaDescModel()
                {
                    Id = 3,
                    Descricao = "MV Seco",
                },
                new MelhorVoltaDescModel()
                {
                    Id = 4,
                    Descricao = "MV Misto",
                },
                new MelhorVoltaDescModel()
                {
                    Id = 5,
                    Descricao = "MV Chuva",
                }
            };

            return Ok(mv);
        }
    }
}
