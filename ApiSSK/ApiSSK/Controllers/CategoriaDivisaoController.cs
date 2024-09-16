using Microsoft.AspNetCore.Mvc;

namespace ApiSSK.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriaDivisaoController : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<List<CategoriaDivisaoModel>>> GetAllCategoriasDivisoes()
        {
            var cXd = new List<CategoriaDivisaoModel>()
            {
                new CategoriaDivisaoModel()
                {
                    CategoriaId = 1,
                    DivisaoId = 1,
                    Categoria = new CategoriaModel(){ CatId = 1 },
                    Divisao = new DivisaoModel(){ DivId = 1 }
                },
                new CategoriaDivisaoModel()
                {
                    CategoriaId = 2,
                    DivisaoId = 2,
                    Categoria = new CategoriaModel(){ CatId = 2 },
                    Divisao = new DivisaoModel(){ DivId = 2 }
                }
            };

            return Ok(cXd);
        }
    }
}
