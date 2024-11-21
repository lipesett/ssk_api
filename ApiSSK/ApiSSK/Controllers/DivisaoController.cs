using Microsoft.AspNetCore.Mvc;

namespace ApiSSK.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DivisaoController : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<List<DivisaoModel>>> GetAllDivisao()
        {
            var divisao = new List<DivisaoModel>()
            {
                new DivisaoModel()
                {
                    Id = 1,
                    Nome = "Divisão 80kg",
                    StatusId = 1,
                    Status = new StatusModel{ Id = 1, Descricao = "Ativo" }
                },
                new DivisaoModel()
                {
                    Id = 1,
                    Nome = "Divisão 95kg",
                    StatusId = 1,
                    Status = new StatusModel{ Id = 1, Descricao = "Ativo" }
                },
                new DivisaoModel()
                {
                    Id = 1,
                    Nome = "Divisão 110kg",
                    StatusId = 1,
                    Status = new StatusModel{ Id = 2, Descricao = "Inativo" }
                }
            };

            return Ok(divisao);
        }
    }
}
