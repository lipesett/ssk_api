using Microsoft.AspNetCore.Mvc;

namespace ApiSSK.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InscricaoController : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<List<InscricaoModel>>> GetAllInscricoes()
        {
            var inscricao = new List<InscricaoModel>()
            {
                new InscricaoModel()
                {
                    InsId = 1,
                    PilotoId = 1,
                    CategoriaId = 1,
                    DivisaoId = 1,
                    InsDataInscricao = new DateTime(2024, 9, 1),
                    InsPago = 1,
                    TemporadaId = 1,
                    Piloto = new PilotoModel{ PilId = 1 },
                    Categoria = new CategoriaModel{ CatId = 1 },
                    Divisao = new DivisaoModel{ DivId = 1 },
                    Temporada = new TemporadaModel{ TemId = 1 }
                },
                new InscricaoModel()
                {
                    InsId = 2,
                    PilotoId = 2,
                    CategoriaId = 2,
                    DivisaoId = 2,
                    InsDataInscricao = new DateTime(2024, 9, 2),
                    InsPago = 0,
                    TemporadaId = 1,
                    Piloto = new PilotoModel{ PilId = 2 },
                    Categoria = new CategoriaModel{ CatId = 2 },
                    Divisao = new DivisaoModel{ DivId = 2 },
                    Temporada = new TemporadaModel{ TemId = 1 }
                }
            };

            return Ok(inscricao);
        }
    }
}
