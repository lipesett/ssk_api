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
                    StatusId = 1,
                    Status = new StatusModel { StaId = 1, StaDesc = "Ativo" }
                },
                new CategoriaModel()
                {
                    CatId = 2,
                    CatNome = "Categoria Senna",
                    StatusId = 1,
                    Status = new StatusModel { StaId = 1, StaDesc = "Ativo" }
                },
                new CategoriaModel()
                {
                    CatId = 3,
                    CatNome = "Categoria Binnoto",
                    StatusId = 2,
                    Status = new StatusModel { StaId = 2, StaDesc = "Inativo" }
                }
            };

            return Ok(categorias);
        }
    }
}
