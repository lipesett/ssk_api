using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiSSK.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriaDivisaoController : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<List<CategoriaDivisao>>> GetAllCategoriasDivisoes()
        {
            var cXd = new List<CategoriaDivisao>()
            {
                new CategoriaDivisao()
                {
                    CatId = 1,
                    DivId = 1,
                    Categoria = new Categoria(){ CatId = 1 },
                    Divisao = new Divisao(){ DivId = 1 }
                },
                new CategoriaDivisao()
                {
                    CatId = 2,
                    DivId = 2,
                    Categoria = new Categoria(){ CatId = 2 },
                    Divisao = new Divisao(){ DivId = 2 }
                }
            };

            return Ok(cXd);
        }
    }
}
