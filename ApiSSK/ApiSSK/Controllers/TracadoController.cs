using Microsoft.AspNetCore.Mvc;

namespace ApiSSK.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TracadoController : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<List<TracadoModel>>> GetAllTracados()
        {
            var tracados = new List<TracadoModel>()
            {
                new TracadoModel()
                {
                    TraId = 1,
                    TraNome = "Traçado 101",
                    TraDataEstreia = new DateTime(2024, 01, 29),
                    TraImg = "www.google.com",
                    ClimaId = 1,
                    KartodromoId = 1,
                    MvEstreiaId = 1,
                    MvRecordId = 2,
                    SentidoId = 1,
                    Clima = new ClimaModel(){ CliId = 1},
                    Kartodromo = new KartodromoModel(){ KarId = 1},
                    MvEstreia = new MelhorVoltaModel(){ MvId = 1},
                    MvRecord = new MelhorVoltaModel(){ MvId = 2},
                    Sentido = new SentidoModel{ SenId = 1}
                },
                new TracadoModel()
                {
                    TraId = 2,
                    TraNome = "Traçado 116",
                    TraDataEstreia = new DateTime(2024, 03, 15),
                    TraImg = "www.google.com",
                    ClimaId = 2,
                    KartodromoId = 1,
                    MvEstreiaId = 1,
                    MvRecordId = 2,
                    SentidoId = 2,
                    Clima = new ClimaModel(){ CliId = 2},
                    Kartodromo = new KartodromoModel(){ KarId = 1},
                    MvEstreia = new MelhorVoltaModel(){ MvId = 1},
                    MvRecord = new MelhorVoltaModel(){ MvId = 2},
                    Sentido = new SentidoModel{ SenId = 2}
                }
            };

            return Ok(tracados);
        }
    }
}
