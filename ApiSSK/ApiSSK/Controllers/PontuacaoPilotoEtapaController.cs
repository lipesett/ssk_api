using ApiSSK.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ApiSSK.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PontuacaoPilotoEtapaController : ControllerBase
    {
        private readonly IPontuacaoPilotoEtapaRepository _ppeRepository;

        public PontuacaoPilotoEtapaController(IPontuacaoPilotoEtapaRepository ppeRepository)
        {
            _ppeRepository = ppeRepository;
        }

        [HttpGet]
        public async Task<ActionResult<List<PontuacaoPilotoEtapaModel>>> GetAllPontuacoesPilotosEtapa()
        {
            return await _ppeRepository.GetAllPontuacaoPilotoEtapas();
        }
    }
}