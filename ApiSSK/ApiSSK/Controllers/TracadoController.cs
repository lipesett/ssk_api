using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiSSK.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TracadoController : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<List<Tracado>>> GetAllTracados()
        {
            var tracados = new List<Tracado>()
            {
                new Tracado()
                {
                    TraId = 1,
                    TraNome = "Traçado 101",
                    TraDataEstreia = new DateTime(2024, 01, 29),
                    TraImg = "www.google.com",
                    CliClima = 1,
                    KarKartodromo = 1,
                    MvEstreiaId = 1,
                    MvRecordId = 2,
                    SenSentido = 1,
                    Clima = new ClimaModel(){ CliId = 1},
                    Kartodromo = new KartodromoModel(){ KarId = 1},
                    MvEstreia = new MelhorVoltaModel(){ MvId = 1},
                    MvRecord = new MelhorVoltaModel(){ MvId = 2},
                    Sentido = new Sentido(){ SenId = 1}
                },
                new Tracado()
                {
                    TraId = 2,
                    TraNome = "Traçado 116",
                    TraDataEstreia = new DateTime(2024, 03, 15),
                    TraImg = "www.google.com",
                    CliClima = 2,
                    KarKartodromo = 1,
                    MvEstreiaId = 1,
                    MvRecordId = 2,
                    SenSentido = 2,
                    Clima = new ClimaModel(){ CliId = 2},
                    Kartodromo = new KartodromoModel(){ KarId = 1},
                    MvEstreia = new MelhorVoltaModel(){ MvId = 1},
                    MvRecord = new MelhorVoltaModel(){ MvId = 2},
                    Sentido = new Sentido(){ SenId = 2}
                }
            };

            return Ok(tracados);
        }
    }
}
