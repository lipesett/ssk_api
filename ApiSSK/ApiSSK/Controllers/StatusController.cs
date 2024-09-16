using Microsoft.AspNetCore.Mvc;

namespace ApiSSK.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatusController : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<List<Status>>> GetAllStatus()
        {
            var status = new List<Status>()
            {
                new Status() {
                    StaId = 1,
                    StaDesc = "mock 1"
                },
                new Status()
                {
                    StaId = 2,
                    StaDesc = "mock 2"
                }
            };

            return Ok(status);
        }
    }
}
