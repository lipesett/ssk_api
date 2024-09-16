using Microsoft.AspNetCore.Http;
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
                    CatId = 1,
                    DivId = 1,
                    Categoria = new CategoriaModel(){ CatId = 1 },
                    Divisao = new DivisaoModel(){ DivId = 1 }
                },
                new CategoriaDivisaoModel()
                {
                    CatId = 2,
                    DivId = 2,
                    Categoria = new CategoriaModel(){ CatId = 2 },
                    Divisao = new DivisaoModel(){ DivId = 2 }
                }
            };

            return Ok(cXd);
        }
    }
}
