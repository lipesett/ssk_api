using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiSSK.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MelhorVoltaController : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<List<MelhorVolta>>> GetAllMelhoresVoltas()
        {
            var mv = new List<MelhorVolta>()
            {
                new MelhorVolta()
                {
                    MvId = 1,
                    MvTipo = "Estreia",
                    MvTempo = "00:54.273",
                    PilMv = 1,
                    CliClima = 1,
                    CalNumeroEtapa = 1,
                    Piloto = new Piloto() { PilId = 1 },
                    Clima = new Clima() { CliId = 1 },
                    Calendario = new Calendario() { CalId = 1 }
                },
                new MelhorVolta()
                {
                    MvId = 2,
                    MvTipo = "Recorde",
                    MvTempo = "00:53.956",
                    PilMv = 2,
                    CliClima = 1,
                    CalNumeroEtapa = 11,
                    Piloto = new Piloto() { PilId = 2 },
                    Clima = new Clima() { CliId = 1 },
                    Calendario = new Calendario() { CalId = 11 }
                }
            };

            return Ok(mv);
        }
    }
}
