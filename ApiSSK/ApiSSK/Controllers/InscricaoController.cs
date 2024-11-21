using ApiSSK.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ApiSSK.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InscricaoController : ControllerBase
    {
        private readonly IInscricaoRepository _inscricaoRepository;

        public InscricaoController(IInscricaoRepository inscricaoRepository)
        {
            _inscricaoRepository = inscricaoRepository;
        }

        [HttpGet]
        public async Task<ActionResult<List<InscricaoModel>>> GetAllInscricoes()
        {
            return await _inscricaoRepository.GetAllInscricoes();
        }
    }
}