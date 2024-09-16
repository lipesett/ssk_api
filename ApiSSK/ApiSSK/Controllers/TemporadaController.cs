using Microsoft.AspNetCore.Mvc;

namespace ApiSSK.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TemporadaController : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<List<Temporada>>> GetAllTemporadas()
        {
            var temporadas = new List<Temporada>() {
                new Temporada(){
                    TemId = 1,
                    TemNumTem = 2024,
                    TemNome = "Temporada 2024",
                    TemEtapas = 12,
                    TemInicio = new DateTime(2024, 1, 15),  // Data de início
                    TemFinal = new DateTime(2024, 12, 15),   // Data de final
                    TemAno = 2024,
                    StaId = 1,
                    Status = new Status { StaId = 1, StaDesc = "Ativo" }
                },
                new Temporada()
                {
                    TemId = 2,
                    TemNumTem = 2023,
                    TemNome = "Temporada 2023",
                    TemEtapas = 10,
                    TemInicio = new DateTime(2023, 3, 1),    // Data de início
                    TemFinal = new DateTime(2023, 11, 30),   // Data de final
                    TemAno = 2023,
                    StaId = 2,
                    Status = new Status { StaId = 2, StaDesc = "Concluído" }
                }
            };

            return Ok(temporadas);
        }
    }
}
