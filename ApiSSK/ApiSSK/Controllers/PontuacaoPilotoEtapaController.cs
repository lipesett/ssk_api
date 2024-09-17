using Microsoft.AspNetCore.Mvc;

namespace ApiSSK.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PontuacaoPilotoEtapaController : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<List<PontuacaoPilotoEtapaModel>>> GetAllPontuacoesPilotosEtapa()
        {
            var ppe = new List<PontuacaoPilotoEtapaModel>()
            {
                new PontuacaoPilotoEtapaModel()
                {
                    PpeId = 1,
                    PilotoId = 1,
                    CalendarioId = 1,
                    PontuacaoId = 1,
                    PpeTempoMelhorVolta = "01:23.456",
                    MelhorVolta = true,
                    Piloto = new PilotoModel(){ PilId = 1 },
                    Calendario = new CalendarioModel(){ CalId = 1 },
                    Pontuacao = new PontuacaoModel(){ PonId = 1 }
                },
                new PontuacaoPilotoEtapaModel()
                {
                    PpeId = 2,
                    PilotoId = 2,
                    CalendarioId = 2,
                    PontuacaoId = 2,
                    PpeTempoMelhorVolta = "01:24.789",
                    MelhorVolta = false,
                    Piloto = new PilotoModel(){ PilId = 2 },
                    Calendario = new CalendarioModel(){ CalId = 2 },
                    Pontuacao = new PontuacaoModel(){ PonId = 2 }
                }
            };

            return Ok(ppe);
        }
    }
}