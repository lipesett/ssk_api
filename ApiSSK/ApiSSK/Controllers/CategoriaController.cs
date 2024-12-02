using ApiSSK.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ApiSSK.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriaController : ControllerBase
    {
        private readonly ICategoriaRepository _categoriaRepository;

        public CategoriaController(ICategoriaRepository categoriaRepository)
        {
            _categoriaRepository = categoriaRepository;
        }

        [HttpGet]
        public async Task<ActionResult<List<CategoriaModel>>> GetAllCategorias()
        {
            return await _categoriaRepository.GetAllCategorias();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<CategoriaModel>> GetCategoriaById(int id)
        {
            return await _categoriaRepository.GetCategoriaById(id);
        }

        [HttpPost]
        public async Task<ActionResult<CategoriaModel>> AdicionarCategoria([FromBody] CategoriaModel categoriaModel)
        {
            return await _categoriaRepository.AdicionarCategoria(categoriaModel);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<CategoriaModel>> AtualizarCategoria([FromBody] CategoriaModel categoriaModel, int id)
        {
            categoriaModel.Id = id;
            return await _categoriaRepository.AtualizarCategoria(categoriaModel, id);
        }

        [HttpDelete("{id}")]
        public async Task<bool> DeletarCategoria(int id)
        {
            return await _categoriaRepository.DeletarCategoria(id);
        }
    }
}