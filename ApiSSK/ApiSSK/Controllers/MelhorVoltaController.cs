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
                    MvId = 1,
                    MelhorVoltaDescId = 1,
                    MvTempo = "00:54.273",
                    PilotoId = 1,
                    ClimaId = 1,
                    CalendarioId = 1,
                    Piloto = new PilotoModel{ PilId = 1 },
                    Clima = new ClimaModel{ CliId = 1 },
                    Calendario = new CalendarioModel{ CalId = 1 }
                },
                new MelhorVoltaModel()
                {
                    MvId = 2,
                    MelhorVoltaDescId = 2,
                    MvTempo = "00:53.956",
                    PilotoId = 2,
                    ClimaId = 1,
                    CalendarioId = 11,
                    Piloto = new PilotoModel{ PilId = 2 },
                    Clima = new ClimaModel{ CliId = 1 },
                    Calendario = new CalendarioModel{ CalId = 11 }
                }
            };

            return Ok(mv);
        }
    }
}
