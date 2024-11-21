using Microsoft.AspNetCore.Mvc;

namespace ApiSSK.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatusController : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<List<StatusModel>>> GetAllStatus()
        {
            var status = new List<StatusModel>()
            {
                new StatusModel() {
                    Id = 1,
                    Descricao = "mock 1"
                },
                new StatusModel()
                {
                    Id = 2,
                    Descricao = "mock 2"
                }
            };
            return Ok(status);
        }
    }
}