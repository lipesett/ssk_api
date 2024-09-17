using Microsoft.AspNetCore.Http;
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
                    StaId = 1,
                    StaDesc = "mock 1"
                },
                new StatusModel()
                {
                    StaId = 2,
                    StaDesc = "mock 2"
                }
            };

            return Ok(status);
        }
    }
}
