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
                    Id = 1,
                    Nome = "Kartódromo Granja Viana",
                    Apelido = "Granja Viana",
                    NomCurto = "KGV"
                },
                new KartodromoModel()
                {
                    Id = 2,
                    Nome = "Kartódromo Nova Odessa",
                    Apelido = "Nova Odessa",
                    NomCurto = "KNO"
                }
            };

            return Ok(kartodromos);
        }
    }
}
