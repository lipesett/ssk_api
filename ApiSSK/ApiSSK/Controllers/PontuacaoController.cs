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
                    Id = 1,
                    Posicao = 1,
                    Pontos = 40,
                    TemporadaId = 1,
                    Temporada = new TemporadaModel{ Id = 1 }
                },
                new PontuacaoModel()
                {
                    Id = 2,
                    Posicao = 1,
                    Pontos = 35,
                    TemporadaId = 1,
                    Temporada = new TemporadaModel{ Id = 1 }
                },
            };

            return Ok(pontuacao);
        }
    }
}
