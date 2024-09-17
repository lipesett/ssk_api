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
                    DivId = 1,
                    DivNome = "Divisão 80kg",
                    StatusId = 1,
                    Status = new StatusModel{ StaId = 1, StaDesc = "Ativo" }
                },
                new DivisaoModel()
                {
                    DivId = 1,
                    DivNome = "Divisão 95kg",
                    StatusId = 1,
                    Status = new StatusModel{ StaId = 1, StaDesc = "Ativo" }
                },
                new DivisaoModel()
                {
                    DivId = 1,
                    DivNome = "Divisão 110kg",
                    StatusId = 1,
                    Status = new StatusModel{ StaId = 2, StaDesc = "Inativo" }
                }
            };

            return Ok(divisao);
        }
    }
}
