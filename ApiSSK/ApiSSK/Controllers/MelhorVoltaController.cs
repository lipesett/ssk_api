using Microsoft.AspNetCore.Http;
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
                    MvTipo = "Estreia",
                    MvTempo = "00:54.273",
                    PilMv = 1,
                    CliClima = 1,
                    CalNumeroEtapa = 1,
                    Piloto = new PilotoModel() { PilId = 1 },
                    Clima = new ClimaModel() { CliId = 1 },
                    Calendario = new CalendarioModel() { CalId = 1 }
                },
                new MelhorVoltaModel()
                {
                    MvId = 2,
                    MvTipo = "Recorde",
                    MvTempo = "00:53.956",
                    PilMv = 2,
                    CliClima = 1,
                    CalNumeroEtapa = 11,
                    Piloto = new PilotoModel() { PilId = 2 },
                    Clima = new ClimaModel() { CliId = 1 },
                    Calendario = new CalendarioModel() { CalId = 11 }
                }
            };

            return Ok(mv);
        }
    }
}
