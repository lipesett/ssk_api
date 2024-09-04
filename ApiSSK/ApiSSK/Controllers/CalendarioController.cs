using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiSSK.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalendarioController : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<List<Calendario>>> GetAllCalendarios()
        {
            var calendario = new List<Calendario>()
            {
                new Calendario()
                {
                    CalId = 1,
                    CalNomeEtapa = "Etapa 1",
                    CalNumEtapa = 1,
                    CalDia = 15,
                    CalMes = 9,
                    CalAno = 2024,
                    CalDataCompleta = new DateTime(2024, 9, 15),
                    CalHorario = new TimeSpan(10, 30, 0),
                    CalPtsDisputados = 41,
                    CalEtapaRealizada = true,
                    TraTracado = 1,
                    TemTemporada = 2024,
                    PilPilotoVencedor = 1,
                    Tracado = new Tracado { TraId = 1 },
                    Temporada = new Temporada { TemId = 1 },
                    PilotoVencedor = new Piloto { PilId = 1 }
                }
            };

            return Ok(calendario);
        }
    }
}
