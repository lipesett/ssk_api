using ApiSSK.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ApiSSK.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DivisaoController : ControllerBase
    {
        private readonly IDivisaoRepository _divisaoRepository;

        public DivisaoController(IDivisaoRepository divisaoRepository)
        {
            _divisaoRepository = divisaoRepository;
        }

        [HttpGet]
        public async Task<ActionResult<List<DivisaoModel>>> GetAllDivisao()
        {
            return await _divisaoRepository.GetAllDivisoes();
        }

        [HttpPost]
        public async Task<ActionResult<DivisaoModel>> AddDivisao(DivisaoModel divisao)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            
            return await _divisaoRepository.AdicionarDivisao(divisao);
        }
    }
}