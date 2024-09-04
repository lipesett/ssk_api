using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiSSK.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KartodromoController : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<List<Kartodromo>>> GetAllKartodromos()
        {
            var kartodromos = new List<Kartodromo>()
            {
                new Kartodromo()
                {
                    KarId = 1,
                    KarNome = "Kartódromo Granja Viana",
                    KarApelido = "Granja Viana",
                    KarNomCurto = "KGV"
                },
                new Kartodromo()
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
