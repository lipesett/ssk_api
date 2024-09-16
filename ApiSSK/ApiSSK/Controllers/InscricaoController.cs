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
                    PilId = 1,
                    CatId = 1,
                    DivId = 1,
                    InsDataInscricao = new DateTime(2024, 9, 1),
                    InsPago = 1,
                    TemId = 1,
                    Piloto = new PilotoModel(){ PilId = 1 },
                    Categoria = new CategoriaModel(){ CatId = 1 },
                    Divisao = new DivisaoModel(){ DivId = 1 },
                    Temporada = new Temporada(){ TemId = 1 }
                },
                new InscricaoModel()
                {
                    InsId = 2,
                    PilId = 2,
                    CatId = 2,
                    DivId = 2,
                    InsDataInscricao = new DateTime(2024, 9, 2),
                    InsPago = 0,
                    TemId = 1,
                    Piloto = new PilotoModel(){ PilId = 2 },
                    Categoria = new CategoriaModel(){ CatId = 2 },
                    Divisao = new DivisaoModel(){ DivId = 2 },
                    Temporada = new Temporada(){ TemId = 1 }
                }
            };

            return Ok(inscricao);
        }
    }
}
