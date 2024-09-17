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
                    TemporadaId = 1,
                    Temporada = new TemporadaModel{ TemId = 1, StatusId = 1 }
                },
                new PontuacaoModel()
                {
                    PonId = 2,
                    PonPosicao = 1,
                    PonPontos = 35,
                    TemporadaId = 1,
                    Temporada = new TemporadaModel{ TemId = 1, StatusId = 1 }
                },
            };

            return Ok(pontuacao);
        }
    }
}
