using Microsoft.AspNetCore.Mvc;

namespace ApiSSK.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MelhorVoltaController : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<List<MelhorVoltaModel>>> GetAllMelhoresVoltas()
        {
            var mv = new List<MelhorVoltaModel>()
            {
                new MelhorVoltaModel()
                {
                    Id = 1,
                    MelhorVoltaDescId = 1,
                    Tempo = "00:54.273",
                    PilotoId = 1,
                    ClimaId = 1,
                    CalendarioId = 1,
                    Piloto = new PilotoModel{ Id = 1 },
                    Clima = new ClimaModel{ Id = 1 },
                    Calendario = new CalendarioModel{ Id = 1 }
                },
                new MelhorVoltaModel()
                {
                    Id = 2,
                    MelhorVoltaDescId = 2,
                    Tempo = "00:53.956",
                    PilotoId = 2,
                    ClimaId = 1,
                    CalendarioId = 11,
                    Piloto = new PilotoModel{ Id = 2 },
                    Clima = new ClimaModel{ Id = 1 },
                    Calendario = new CalendarioModel{ Id = 11 }
                }
            };

            return Ok(mv);
        }
    }
}
