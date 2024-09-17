using Microsoft.AspNetCore.Mvc;

namespace ApiSSK.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PontuacaoController : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<List<PontuacaoModel>>> GetAllPontuacoes()
        {
            var pontuacao = new List<PontuacaoModel>()
            {
                new PontuacaoModel()
                {
                    PonId = 1,
                    PonPosicao = 1,
                    PonPontos = 40,
                    TemTemporada = 1,
                    Temporada = new Temporada(){ TemId = 1, StaId = 1 }
                },
                new PontuacaoModel()
                {
                    PonId = 2,
                    PonPosicao = 1,
                    PonPontos = 35,
                    TemTemporada = 1,
                    Temporada = new Temporada(){ TemId = 1, StaId = 1 }
                },
            };

            return Ok(pontuacao);
        }
    }
}
