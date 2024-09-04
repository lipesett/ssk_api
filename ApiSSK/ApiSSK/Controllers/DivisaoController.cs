using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiSSK.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DivisaoController : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<List<Divisao>>> GetAllDivisao()
        {
            var divisao = new List<Divisao>()
            {
                new Divisao()
                {
                    DivId = 1,
                    DivNome = "Divisão 80kg",
                    StaId = 1,
                    Status = new Status() { StaId = 1, StaDesc = "Ativo" }
                },
                new Divisao()
                {
                    DivId = 1,
                    DivNome = "Divisão 95kg",
                    StaId = 1,
                    Status = new Status() { StaId = 1, StaDesc = "Ativo" }
                },
                new Divisao()
                {
                    DivId = 1,
                    DivNome = "Divisão 110kg",
                    StaId = 1,
                    Status = new Status() { StaId = 2, StaDesc = "Inativo" }
                }
            };

            return Ok(divisao);
        }
    }
}
