using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiSSK.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PontuacaoPilotoEtapaController : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<List<PontuacaoPilotoEtapa>>> GetAllPontuacoesPilotosEtapa()
        {
            var ppe = new List<PontuacaoPilotoEtapa>()
            {
                new PontuacaoPilotoEtapa()
                {
                    PpeId = 1,
                    PilId = 1,
                    CalId = 1,
                    PonId = 1,
                    PpeTempoMelhorVolta = "01:23.456",
                    MelhorVolta = true,
                    Piloto = new PilotoModel(){ PilId = 1 },
                    Calendario = new CalendarioModel(){ CalId = 1 },
                    Pontuacao = new Pontuacao(){ PonId = 1 }
                },
                new PontuacaoPilotoEtapa()
                {
                    PpeId = 2,
                    PilId = 2,
                    CalId = 2,
                    PonId = 2,
                    PpeTempoMelhorVolta = "01:24.789",
                    MelhorVolta = false,
                    Piloto = new PilotoModel(){ PilId = 2 },
                    Calendario = new CalendarioModel(){ CalId = 2 },
                    Pontuacao = new Pontuacao(){ PonId = 2 }
                }
            };

            return Ok(ppe);
        }
    }
}