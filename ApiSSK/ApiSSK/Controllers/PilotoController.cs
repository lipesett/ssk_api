using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiSSK.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PilotoController : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<List<PilotoModel>>> GetAllPilotos()
        {
            var pilotos = new List<PilotoModel>()
            {
                new PilotoModel()
                {
                    PilId = 1,
                    PilNome = "Rodrigo",
                    PilSobrenome = "Poquiviqui",
                    PilPodiums = 4,
                    PilCampeao = 1,
                    PilCorridasOfc = 32,
                    PilMelhorChegada = 1,
                    PilPeso = "70.8",
                    PilMelhorQuali = 1,
                    PilPolePosition = 4,
                    PilVoltasRapidas = 2,
                    PilUltimaTemp = 1,
                    PilLinksFotos = "www.google.com",
                    StaId = 1,
                    Status = new Status(){ StaId = 1, StaDesc = "Ativo" }
                },
                new PilotoModel()
                {
                    PilId = 1,
                    PilNome = "Felipe",
                    PilSobrenome = "Lucas",
                    PilPodiums = 4,
                    PilCampeao = 1,
                    PilCorridasOfc = 32,
                    PilMelhorChegada = 1,
                    PilPeso = "65.8",
                    PilMelhorQuali = 1,
                    PilPolePosition = 4,
                    PilVoltasRapidas = 2,
                    PilUltimaTemp = 1,
                    PilLinksFotos = "www.google.com",
                    StaId = 1,
                    Status = new Status(){ StaId = 1, StaDesc = "Ativo" }
                }
            };

            return Ok(pilotos);
        }
    }
}
