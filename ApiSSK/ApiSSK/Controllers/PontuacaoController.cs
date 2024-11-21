using ApiSSK.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ApiSSK.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PontuacaoController : ControllerBase
    {
        private readonly IPontuacaoRepository _pontuacaoRepository;

        public PontuacaoController(IPontuacaoRepository pontuacaoRepository)
        {
            _pontuacaoRepository = pontuacaoRepository;
        }

        [HttpGet]
        public async Task<ActionResult<List<PontuacaoModel>>> GetAllPontuacoes()
        {
            return await _pontuacaoRepository.GetAllPontuacoes();
        }
    }
}