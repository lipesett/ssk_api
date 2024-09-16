using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiSSK.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriaController : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<List<CategoriaModel>>> GetAllCategorias()
        {
            var categorias = new List<CategoriaModel>()
            {
                new CategoriaModel()
                {
                    CatId = 1,
                    CatNome = "Categoria Borracha",
                    StaId = 1,
                    Status = new Status { StaId = 1, StaDesc = "Ativo" }
                },
                new CategoriaModel()
                {
                    CatId = 2,
                    CatNome = "Categoria Senna",
                    StaId = 1,
                    Status = new Status { StaId = 1, StaDesc = "Ativo" }
                },
                new CategoriaModel()
                {
                    CatId = 3,
                    CatNome = "Categoria Binnoto",
                    StaId = 2,
                    Status = new Status { StaId = 2, StaDesc = "Inativo" }
                }
            };

            return Ok(categorias);
        }
    }
}
