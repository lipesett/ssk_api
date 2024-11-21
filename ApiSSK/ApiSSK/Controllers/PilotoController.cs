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
                    Id = 1,
                    Nome = "Rodrigo",
                    Sobrenome = "Poquiviqui",
                    Podiuns = 4,
                    Campeao = 1,
                    CorridasOfc = 32,
                    MelhorChegada = 1,
                    Peso = "70.8",
                    MelhorQuali = 1,
                    PolePosition = 4,
                    VoltasRapidas = 2,
                    UltimaTemp = 1,
                    LinksFotos = "www.google.com",
                    StatusId = 1,
                    Status = new StatusModel{ Id = 1, Descricao = "Ativo" }
                },
                new PilotoModel()
                {
                    Id = 1,
                    Nome = "Felipe",
                    Sobrenome = "Lucas",
                    Podiuns = 4,
                    Campeao = 1,
                    CorridasOfc = 32,
                    MelhorChegada = 1,
                    Peso = "65.8",
                    MelhorQuali = 1,
                    PolePosition = 4,
                    VoltasRapidas = 2,
                    UltimaTemp = 1,
                    LinksFotos = "www.google.com",
                    StatusId = 1,
                    Status = new StatusModel{ Id = 1, Descricao = "Ativo" }
                }
            };

            return Ok(pilotos);
        }
    }
}