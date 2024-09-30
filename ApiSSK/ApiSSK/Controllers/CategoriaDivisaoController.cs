using ApiSSK.Repositories;
using ApiSSK.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ApiSSK.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriaDivisaoController : ControllerBase
    {
        private readonly ICategoriaDivisaoRepository _categoriaDivisaoRepository;
        public CategoriaDivisaoController(ICategoriaDivisaoRepository categoriaDivisaoRepository)
        {
            _categoriaDivisaoRepository = categoriaDivisaoRepository;
        }

        [HttpGet]
        public async Task<ActionResult<List<CategoriaDivisaoModel>>> GetAllCategoriasDivisoes()
        {
            return await _categoriaDivisaoRepository.GetAllCategoriasDivisoes();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<CategoriaDivisaoModel>> GetAllCategoriasDivisoes(int id)
        {
            return await _categoriaDivisaoRepository.GetCategoriaDivisaoById(id);
        }

        [HttpPost]
        public async Task<ActionResult<CategoriaDivisaoModel>> AdicionarClima([FromBody] CategoriaDivisaoModel categoriaDivisaoModel)
        {
            CategoriaDivisaoModel clima = await _categoriaDivisaoRepository.AdicionarCategoriaDivisao(categoriaDivisaoModel);
            return Ok(clima);
        }

        [HttpDelete]
        public async Task<ActionResult<CategoriaDivisaoModel>> DeletarClima(int id)
        {
            bool deletado = await _categoriaDivisaoRepository.DeletarCategoriaDivisao(id);
            return Ok(deletado);
        }
    }
}
