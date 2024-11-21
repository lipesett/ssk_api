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
                    Id = 1,
                    PilotoId = 1,
                    CalendarioId = 1,
                    PontuacaoId = 1,
                    TempoMelhorVolta = "01:23.456",
                    MelhorVolta = true,
                    Piloto = new PilotoModel(){ Id = 1 },
                    Calendario = new CalendarioModel(){ Id = 1 },
                    Pontuacao = new PontuacaoModel(){ Id = 1 }
                },
                new PontuacaoPilotoEtapaModel()
                {
                    Id = 2,
                    PilotoId = 2,
                    CalendarioId = 2,
                    PontuacaoId = 2,
                    TempoMelhorVolta = "01:24.789",
                    MelhorVolta = false,
                    Piloto = new PilotoModel(){ Id = 2 },
                    Calendario = new CalendarioModel(){ Id = 2 },
                    Pontuacao = new PontuacaoModel(){ Id = 2 }
                }
            };

            return Ok(ppe);
        }
    }
}