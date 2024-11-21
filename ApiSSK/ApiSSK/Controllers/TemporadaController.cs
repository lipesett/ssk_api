using Microsoft.AspNetCore.Mvc;

namespace ApiSSK.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TemporadaController : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<List<TemporadaModel>>> GetAllTemporadas()
        {
            var temporadas = new List<TemporadaModel>() {
                new TemporadaModel(){
                    Id = 1,
                    NumTem = 2024,
                    Nome = "Temporada 2024",
                    Etapas = 12,
                    Inicio = new DateTime(2024, 1, 15),  // Data de início
                    Final = new DateTime(2024, 12, 15),   // Data de final
                    Ano = 2024,
                    StatusId = 1,
                    Status = new StatusModel{ Id = 1, Descricao = "Ativo" }
                },
                new TemporadaModel()
                {
                    Id = 2,
                    NumTem = 2023,
                    Nome = "Temporada 2023",
                    Etapas = 10,
                    Inicio = new DateTime(2023, 3, 1),    // Data de início
                    Final = new DateTime(2023, 11, 30),   // Data de final
                    Ano = 2023,
                    StatusId = 2,
                    Status = new StatusModel{ Id = 2, Descricao = "Concluído" }
                }
            };
            return Ok(temporadas);
        }
    }
}
