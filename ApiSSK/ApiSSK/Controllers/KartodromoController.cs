using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiSSK.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KartodromoController : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<List<KartodromoModel>>> GetAllKartodromos()
        {
            var kartodromos = new List<KartodromoModel>()
            {
                new KartodromoModel()
                {
                    KarId = 1,
                    KarNome = "Kartódromo Granja Viana",
                    KarApelido = "Granja Viana",
                    KarNomCurto = "KGV"
                },
                new KartodromoModel()
                {
                    KarId = 2,
                    KarNome = "Kartódromo Nova Odessa",
                    KarApelido = "Nova Odessa",
                    KarNomCurto = "KNO"
                }
            };

            return Ok(kartodromos);
        }
    }
}
