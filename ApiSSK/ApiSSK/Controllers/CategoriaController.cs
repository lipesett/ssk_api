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
                    Id = 1,
                    Nome = "Categoria Borracha",
                    StatusId = 1,
                    Status = new StatusModel { Id = 1, Descricao = "Ativo" }
                },
                new CategoriaModel()
                {
                    Id = 2,
                    Nome = "Categoria Senna",
                    StatusId = 1,
                    Status = new StatusModel { Id = 1, Descricao = "Ativo" }
                },
                new CategoriaModel()
                {
                    Id = 3,
                    Nome = "Categoria Binnoto",
                    StatusId = 2,
                    Status = new StatusModel { Id = 2, Descricao = "Inativo" }
                }
            };

            return Ok(categorias);
        }
    }
}
