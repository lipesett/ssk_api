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
                    Id = 1,
                    PilotoId = 1,
                    CategoriaId = 1,
                    DivisaoId = 1,
                    DataInscricao = new DateTime(2024, 9, 1),
                    Pago = true,
                    TemporadaId = 1,
                    Piloto = new PilotoModel{ Id = 1 },
                    Categoria = new CategoriaModel{ Id = 1 },
                    Divisao = new DivisaoModel{ Id = 1 },
                    Temporada = new TemporadaModel{ Id = 1 }
                },
                new InscricaoModel()
                {
                    Id = 2,
                    PilotoId = 2,
                    CategoriaId = 2,
                    DivisaoId = 2,
                    DataInscricao = new DateTime(2024, 9, 2),
                    Pago = false,
                    TemporadaId = 1,
                    Piloto = new PilotoModel{ Id = 2 },
                    Categoria = new CategoriaModel{ Id = 2 },
                    Divisao = new DivisaoModel{ Id = 2 },
                    Temporada = new TemporadaModel{ Id = 1 }
                }
            };

            return Ok(inscricao);
        }
    }
}
